using System;
using System.IO;
using System.Reflection;
using System.Xml;
using Mim.Resolvers;
using Mim.Validators;

namespace Mim.Core.Validators
{
	public sealed class CdaValidator
	{
		private readonly ResourceResolver _externalResolver;
		private readonly StylesheetTransformer _transformer;
		private readonly SchemaValidator _schemaValidator;

		public CdaValidator(ResourceResolver externalResolver)
		{
			_externalResolver = externalResolver ?? throw new ArgumentNullException(nameof(externalResolver));
			_transformer = new StylesheetTransformer();
			_schemaValidator = new SchemaValidator(_externalResolver);
		}

		public static CdaValidator Create(Assembly externalAssembly)
		{
			if (externalAssembly == null) throw new ArgumentNullException(nameof(externalAssembly));

			return new CdaValidator(new EmbeddedResourceResolver(externalAssembly));
		}

		public static CdaValidator Create(string folder)
		{
			if (string.IsNullOrWhiteSpace(folder)) throw new ArgumentException($"{nameof(folder)} is null or whitespace");

			return new CdaValidator(new DirectoryResourceResolver(folder));
		}


		public Result Validate(string inputXml, string templateSchemaName = null)
		{
			try
			{
				InputSchema messageSchema = GetInputSchema(inputXml);

				if (!string.IsNullOrWhiteSpace(templateSchemaName))
					MakeSureSchemaMatches(templateSchemaName, messageSchema);

				Result result = ValidateGenericCda(inputXml, messageSchema.cdaSchema);
				if (!result.Status)
					return result;

				string templateXml = _transformer.Transform(StylesheetDocument.CdaToTemplated, inputXml);

				return ValidateTemplate(templateXml, messageSchema.templateSchema);
			}
			catch (Exception ex)
			{
				return Result.Exception(ex);
			}
		}

		private void MakeSureSchemaMatches(string templateSchemaName, InputSchema messageSchema)
		{
			if (!string.Equals(templateSchemaName.MakeSureHasSchemaExtension(), messageSchema.templateSchema, StringComparison.InvariantCultureIgnoreCase))
				throw new InvalidOperationException($"The argument template schema '{templateSchemaName}' different to the message template schema or message type '{messageSchema.templateSchema}'. Comparison is done by ignoring case and extension");
		}

		private static void Validate(string templateSchemaName, InputSchema messageSchema)
		{
			if (templateSchemaName != null
				&& messageSchema.templateSchema.ToLowerInvariant() != templateSchemaName.MakeSureHasSchemaExtension().ToLowerInvariant())
			{
				throw new InvalidOperationException($"The templateSchemaName argument '{templateSchemaName}' is not the same as the message type specified '{messageSchema.templateSchema}'");
			}
		}

		private Result ValidateGenericCda(string inputXml, string cdaSchema)
		{
			Result result = _schemaValidator.Validate(cdaSchema, inputXml);
			if (!result.Status)
				return PrefixResult(result, $"CDA generic '{cdaSchema}' schema validation");

			result = SchematronValidator.Create(SchematronDocument.GenericCda).Validate(inputXml);

			return !result.Status ? PrefixResult(result, $"CDA generic schematron validation")
				: result;
		}

		private Result ValidateTemplate(string templateXml, string templateSchema)
		{
			Result result = _schemaValidator.Validate(templateSchema, templateXml);

			if (!result.Status)
				return PrefixResult(result, $"Templated CDA '{templateSchema}' schema validation");

			result = SchematronValidator.Create(SchematronDocument.TemplatedCda).Validate(templateXml);
			
			return !result.Status ? PrefixResult(result, $"Templated CDA schematron validation")
				: result;
		}

		private static Result PrefixResult(Result result, string prefix) =>
			new Result(result.Status, $"{prefix}: {result.Description}", result.ErrorException);

		private static InputSchema GetInputSchema(string xml)
		{
			string cdaSchema = string.Empty;
			string templatedSchema = string.Empty;
			using TextReader reader = new StringReader(xml);
			using XmlReader r = XmlReader.Create(reader);				
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
					templatedSchema = r.Value;
					break;
				}
			}		

			return new InputSchema(cdaSchema, templatedSchema);
		}
	}

	internal struct InputSchema
	{
		public string cdaSchema;
		public string templateSchema;

		public InputSchema(string cdaSchema, string templatedSchema)
		{
			this.cdaSchema = cdaSchema.MakeSureHasSchemaExtension();
			this.templateSchema = templatedSchema.MakeSureHasSchemaExtension();
		}

		public override bool Equals(object obj)
		{
			return obj is InputSchema other &&
				   cdaSchema == other.cdaSchema &&
				   templateSchema == other.templateSchema;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(cdaSchema, templateSchema);
		}

		public void Deconstruct(out string cdaSchema, out string templatedSchema)
		{
			cdaSchema = this.cdaSchema;
			templatedSchema = this.templateSchema;
		}

		public static implicit operator (string cdaSchema, string templatedSchema)(InputSchema value)
		{
			return (value.cdaSchema, value.templateSchema);
		}

		public static implicit operator InputSchema((string cdaSchema, string templatedSchema) value)
		{
			return new InputSchema(value.cdaSchema, value.templatedSchema);
		}
	}
}
