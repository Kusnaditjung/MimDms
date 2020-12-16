using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using static Mim.Core.Extensions;

namespace Mim
{
	[Flags]
	public enum SchematronOptions
	{
		None = 0,
		SkipInclude = 1,
		SkipAbstractExpand = 2,
		SkipXsltConversion = 4
	}

	public static class Validation
	{
		public static Result ValidateSchema(Type type, string xml) => ValidateSchema(type.Assembly, type.Name, xml);

		public static Result ValidateSchema(string schemaFolder, string schemaTypeName, string xml)
		{
			var fileResolver = new FileResolver(schemaFolder);
			return ValidateByResolver(schemaTypeName, fileResolver, xml);
		}

		public static Result ValidateSchema(Assembly assembly, string schemaTypeName, string xml)
		{
			var embeddedResourceResolver = new EmbeddedResourceResolver(assembly);
			return ValidateByResolver(schemaTypeName, embeddedResourceResolver, xml);
		}

		private static Result ValidateByResolver(string schemaTypeName, XmlResolver resolver, string xml)
		{
			string errorMessage = string.Empty;
			Exception errorException = null;

			using (Stream schema = (Stream)resolver.GetEntity(new Uri($"C://{schemaTypeName}.xsd"), null, typeof(Stream)))

			{
				var settings = new XmlReaderSettings
				{
					ValidationType = ValidationType.Schema,
					Schemas = new XmlSchemaSet
					{

						XmlResolver = resolver
					}
				};

				settings.Schemas.Add(XmlSchema.Read(schema, null));

				settings.ValidationEventHandler += (s, e) =>
				{
					if (e.Severity == XmlSeverityType.Error)
					{
						errorMessage = e.Message;
						errorException = e.Exception;
					}
				};

				using (var inputStream = xml.CreateTextStream())
				{
					XmlReader reader = XmlReader.Create(inputStream, settings);

					while (reader.Read()) ;
				}

				return errorMessage != string.Empty
					? Result.ErrorAndException(errorMessage, errorException)
					: Result.Success();
			}
		}

		public static Result ValidateCda(Type messageType, string inputXml) =>
			ValidateCda(messageType.Assembly, messageType.Name, inputXml);

		public static Result ValidateCda(Assembly assembly, string messageSchema, string inputXml)
		{
			(string cdaSchema, string messageSchemaFromInput) = GetSchemaFromInput(inputXml);
			if (messageSchema.ToLowerInvariant() != messageSchemaFromInput.ToLowerInvariant())
				return Result.Error($"The message schema from inputXml is different to the argument. Message schema {messageSchemaFromInput}, argument schema {messageSchema}");

			var validateCda = ValidateSchema(assembly, cdaSchema, inputXml);
			if (!validateCda.Status)
				return validateCda;

			var templatedInputXml = Transformation.Transform(TransformType.WireToTemplated, inputXml);

			return ValidateSchema(assembly, messageSchema, templatedInputXml);		
		}

		private static (string cdaSchema, string messageSchema) GetSchemaFromInput(string xml)
		{
			string cdaSchema = string.Empty;
			string messageSchema = string.Empty;
			using (TextReader reader = new StringReader(xml))
			{
				using (XmlReader r = XmlReader.Create(reader))
				{
					while (r.Read())
					{
						if (r.NodeType == XmlNodeType.Element && r.LocalName == "ClinicalDocument")
						{
							r.MoveToAttribute("schemaLocation", "http://www.w3.org/2001/XMLSchema-instance");
							var parts = r.Value.Split(new char[] { '\\', '/', '.' }, StringSplitOptions.RemoveEmptyEntries);
							cdaSchema = parts[parts.Length - 2];
						}
						else if (r.NodeType == XmlNodeType.Element && r.LocalName == "messageType")
						{
							r.MoveToAttribute("extension");
							messageSchema = r.Value;
							break;
						}
					}
				}
			}

			return (cdaSchema, messageSchema);
		}

		static void ValidationEventHandler(object sender, ValidationEventArgs e)
		{
			XmlSeverityType type = XmlSeverityType.Warning;
			if (Enum.TryParse<XmlSeverityType>("Error", out type))
			{
				if (type == XmlSeverityType.Error) throw new Exception(e.Message);
			}
		}		
	}
}
