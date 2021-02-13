using System;
using System.IO;
using Messaging;
using Messaging.Resolvers;
using Messaging.Transformers;

namespace Messaging.Validators
{
	/// <summary>
	/// SchematronValidator is an ISO compliant schematron validator
	/// </summary>
	public sealed class SchematronValidator
	{
		private readonly Stream _schematronStream;
		private readonly ResourceResolver _resolver;
		private readonly StylesheetTransformer _transformer;

		/// <summary>
		/// <see cref="SchematronValidator"/> instance constructor
		/// </summary>
		/// <param name="schematronContent">Schematron content message in XML format</param>
		/// <param name="convertToIsoNamespace">
		/// Flag to indicate whether or not to conver the old XML namespace to new ISO namespace
		/// The old namespace: http://www.ascc.net/xml/schematron
		/// The Iso namespace: http://purl.oclc.org/dsdl/schematron
		/// The validation will fail on old namespace
		/// </param>
		public SchematronValidator(string schematronContent, bool convertToIsoNamespace = false) : 
			this(GetSchematronContent(schematronContent, convertToIsoNamespace).GetStream())
		{
		}

		private static string GetSchematronContent(string schematronContent, bool convertToIsoNamespace) =>
			convertToIsoNamespace ? schematronContent.Replace("http://www.ascc.net/xml/schematron", "http://purl.oclc.org/dsdl/schematron")
			: schematronContent;

		/// <summary>
		/// <see cref="SchematronValidator"/> instance constructor
		/// </summary>
		/// <param name="schematronStream">Schematron content stream</param>
		public SchematronValidator(Stream schematronStream)
		{
			_schematronStream = schematronStream ?? throw new ArgumentNullException(nameof(schematronStream));
			_resolver = EmbeddedResourceResolver.Create(AssemblyType.Library);
			_transformer = new StylesheetTransformer(_resolver);
		}		
		
		/// <summary>
		/// Used to validate a message against the schematron content specified in the constructor
		/// </summary>
		/// <param name="inputXml">input message XML</param>
		/// <returns></returns>
		public Result Validate(string inputXml) => Validate(inputXml.GetStream());		
		
		/// <summary>
		/// Used to validate a message against the schematron content specified in the constructor
		/// </summary>
		/// <param name="inputStream">input message stream</param>
		/// <returns></returns>
		public Result Validate(Stream inputStream)
		{
			try
			{
				using var schematronStream = GetSchematronStylesheetStream();

				using var resultStream = _transformer.TransformStream(schematronStream, inputStream);

				var result = RemoveBOM(resultStream.GetText());

				return string.IsNullOrWhiteSpace(result)
					? Result.Success()
					: Result.Error(result);
			}
			catch(Exception ex)
			{
				return Result.Exception(ex);
			}
		}		

		private  Stream GetSchematronStylesheetStream()
		{
			using var includeStylesheetStream = _resolver.GetResourceStream("iso_dsdl_include.xsl");
			using var stage1Stream = _transformer.TransformStream(includeStylesheetStream, _schematronStream);

			using var expandAbstractStylesheetStream = _resolver.GetResourceStream("iso_abstract_expand.xsl");
			using var stage2Stream = _transformer.TransformStream(expandAbstractStylesheetStream, stage1Stream);

			using var schematronTexStylesheetStream = _resolver.GetResourceStream("iso_schematron_text.xsl");
			return  _transformer.TransformStream(schematronTexStylesheetStream, stage2Stream);
		}

		private static string RemoveBOM(string errorString)
		{
			const char _byteOrderMark = (char)65279;

			if (errorString.Length > 0)
			{
				if (errorString[0] == _byteOrderMark)
				{
					errorString = errorString.Substring(1);
				}
			}

			return errorString;
		}

		/// <summary>
		/// <see cref="SchemaValidator"/> static constructor with an enumerated schematron content for NHS messages)
		/// </summary>
		/// <param name="schematronDocument">Enumerated schematron content, the resources is contained wihtin Messaging.Core assembly</param>
		/// <returns></returns>

		public static SchematronValidator Create(SchematronDocument schematronDocument) =>		
			schematronDocument switch
			{
				SchematronDocument.GenericCda => new SchematronValidator("Generic_CDA_Document_Schematron.xml".GetStreamFromAssembly()),
				SchematronDocument.TemplatedCda => new SchematronValidator("Templated_CDA_Document_Schematron.xml".GetStreamFromAssembly()),
				SchematronDocument.PsisQuery => new SchematronValidator("PSIS_Query_Schematron.xml".GetStreamFromAssembly()),
				SchematronDocument.GenericCdaInteraction => new SchematronValidator("Generic_CDA_Interaction_Schematron.xml".GetStreamFromAssembly()),
				_ => throw new ArgumentOutOfRangeException($"{schematronDocument} has no translation")
			};	
	}

	/// <summary>
	/// Schematron content enumeration for NHS messages
	/// </summary>
	public enum SchematronDocument
	{
		/// <summary>
		/// Schematron content for generic CDA message
		/// </summary>
		GenericCda,
		/// <summary>
		/// Schematron content for templated CDA message
		/// </summary>
		TemplatedCda,
		/// <summary>
		/// Schematron content for HL7 V3 interaction
		/// </summary>
		GenericCdaInteraction,
		/// <summary>
		/// Schematron content for PSIS Query message
		/// </summary>
		PsisQuery
	}
}
