using System;
using System.IO;
using System.Reflection;
using System.Xml;
using Messaging.Resolvers;
using Messaging.Transformers;

namespace Messaging.Validators
{
	/// <summary>
	/// CdaValidator is used to validate against CDA generic format messages
	/// It contains a series of validation and transformation:
	/// - Schema validation against CDA generic message
	/// - Schematron validation against CDA generic message
	/// - Transformation to templated CDA message
	/// - Schema validation against templated CDA message
	/// - Schematron validation against templated CDA message
	/// </summary>
	public sealed class CdaValidator
	{
		private readonly ResourceResolver _externalResolver;
		private readonly StylesheetTransformer _transformer;
		private readonly SchemaValidator _schemaValidator;

		/// <summary>
		/// <see cref="CdaValidator"/> instance constructor 
		/// </summary>
		/// <param name="externalResolver">Resource resolver particularly for schema</param>
		public CdaValidator(ResourceResolver externalResolver)
		{
			_externalResolver = externalResolver ?? throw new ArgumentNullException(nameof(externalResolver));
			_transformer = new StylesheetTransformer();
			_schemaValidator = new SchemaValidator(_externalResolver);
		}
		/// <summary>
		/// Create is a <see cref="CdaValidator"/> static constructor
		/// </summary>
		/// <param name="externalAssembly">Assembly containing the schema as embedded resources</param>
		/// <returns></returns>
		public static CdaValidator Create(Assembly externalAssembly)
		{
			if (externalAssembly == null) throw new ArgumentNullException(nameof(externalAssembly));

			return new CdaValidator(new EmbeddedResourceResolver(externalAssembly));
		}

		/// <summary>
		/// Create is a <see cref="CdaValidator"/> static constructor
		/// </summary>
		/// <param name="folder">folder containing the schema</param>
		/// <returns></returns>
		public static CdaValidator Create(string folder)
		{
			if (string.IsNullOrWhiteSpace(folder)) throw new ArgumentException($"{nameof(folder)} is null or whitespace");

			return new CdaValidator(new DirectoryResourceResolver(folder));
		}

		/// <summary>
		/// Validate the generic CDA message
		/// </summary>
		/// <param name="inputXml">generic CDA message in XML</param>
		/// <param name="templateSchemaName">optional template schema name, if not present it will use whatever template schema name present in the input XML</param>
		/// <param name="genericCdaSchemaName">optional CDA schema name, if not present if twill use whatever CDA schem name present in the input XML</param>
		/// <returns></returns>
		public Result Validate(string inputXml, string templateSchemaName = null, string genericCdaSchemaName = null)
		{
			try
			{
				InputSchema messageSchema = GetInputSchema(inputXml);

				if (!string.IsNullOrWhiteSpace(templateSchemaName))
					MakeSureSchemaMatches("generic CDA schema", templateSchemaName, messageSchema.TemplateSchema);

				if (!string.IsNullOrEmpty(genericCdaSchemaName))
					MakeSureSchemaMatches("templated CDA schema", genericCdaSchemaName, messageSchema.CdaSchema);

				Result result = ValidateGenericCda(inputXml, messageSchema.CdaSchema);
				if (!result.Status)
					return result;

				string templateXml = _transformer.Transform(StylesheetDocument.CdaToTemplated, inputXml);

				return ValidateTemplate(templateXml, messageSchema.TemplateSchema);
			}
			catch (Exception ex)
			{
				return Result.Exception(ex);
			}
		}

		private void MakeSureSchemaMatches(string schemaType, string givenSchemaName, string extractedSchemaName)
		{
			if (!string.Equals(givenSchemaName.MakeSureHasSchemaExtension(), extractedSchemaName, StringComparison.InvariantCultureIgnoreCase))
				throw new InvalidOperationException($"The argument {schemaType} '{givenSchemaName}' is different to {schemaType} contained within the message '{extractedSchemaName}'. Comparison is done by ignoring case and extension");
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
		public string CdaSchema;
		public string TemplateSchema;

		public InputSchema(string cdaSchema, string templatedSchema)
		{
			this.CdaSchema = cdaSchema.MakeSureHasSchemaExtension();
			this.TemplateSchema = templatedSchema.MakeSureHasSchemaExtension();
		}

		public override bool Equals(object obj)
		{
			return obj is InputSchema other &&
				   CdaSchema == other.CdaSchema &&
				   TemplateSchema == other.TemplateSchema;
		}

		public override int GetHashCode()
		{
			int hash = 17;
			// Suitable nullity checks etc, of course :)
			hash = hash * 23 + CdaSchema.GetHashCode();
			hash = hash * 23 + TemplateSchema.GetHashCode();
			return hash;
		}

		public void Deconstruct(out string cdaSchema, out string templatedSchema)
		{
			cdaSchema = this.CdaSchema;
			templatedSchema = this.TemplateSchema;
		}

		public static implicit operator (string cdaSchema, string templatedSchema)(InputSchema value)
		{
			return (value.CdaSchema, value.TemplateSchema);
		}

		public static implicit operator InputSchema((string cdaSchema, string templatedSchema) value)
		{
			return new InputSchema(value.cdaSchema, value.templatedSchema);
		}
	}
}
