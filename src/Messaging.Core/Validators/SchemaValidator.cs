using System;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using Messaging.Resolvers;

namespace Messaging.Validators
{
	/// <summary>
	/// SchemaValidator is a schema validator
	/// </summary>
	public sealed class SchemaValidator
	{
		private readonly ResourceResolver _externalResolver;

		/// <summary>
		/// <see cref="SchemaValidator"/> instance constructor
		/// </summary>
		/// <param name="externalResolver">Resource resolver for the </param>
		public SchemaValidator(ResourceResolver externalResolver)
		{
			_externalResolver = externalResolver ?? throw new ArgumentNullException(nameof(externalResolver));
		}

		public static SchemaValidator Create(Assembly externalAssembly)
		{
			if (externalAssembly == null) throw new ArgumentNullException(nameof(externalAssembly));

			return new SchemaValidator(new EmbeddedResourceResolver(externalAssembly));
		}
		public static SchemaValidator Create(string folder)
		{
			if (string.IsNullOrWhiteSpace(folder)) throw new ArgumentNullException($"{nameof(folder)} is null or whitespace");

			return new SchemaValidator(new DirectoryResourceResolver(folder));
		}
		
		public Result Validate(string schemaName, string inputXml)
		{
			using var schemaStream = _externalResolver.GetResourceStream(schemaName.MakeSureHasSchemaExtension());
			using var inputXmlStream = inputXml.GetStream();			 
			return Validate(schemaStream, inputXmlStream);
		}

		public Result Validate(Stream schemaStream, Stream inputXmlStream)
		{
			try
			{
				string errorMessage = string.Empty;
				Exception errorException = null;

				var settings = new XmlReaderSettings
				{
					ValidationType = ValidationType.Schema,
					Schemas = new XmlSchemaSet
					{
						XmlResolver = _externalResolver
					}
				};

				settings.Schemas.Add(XmlSchema.Read(schemaStream, null));

				settings.ValidationEventHandler += (s, e) =>
				{
					if (e.Severity == XmlSeverityType.Error)
					{
						errorMessage = e.Message;
						errorException = e.Exception;
					}
				};
				
				using var reader = XmlReader.Create(inputXmlStream, settings);
				while (reader.Read());				

				return !string.IsNullOrWhiteSpace(errorMessage) 
					? Result.ErrorAndException(errorMessage, errorException)
					: Result.Success();
			}
			catch(Exception ex)
			{
				return Result.Exception(ex);
			}			
		}
	}
}
