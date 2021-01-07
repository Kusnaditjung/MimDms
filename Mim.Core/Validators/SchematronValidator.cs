using System;
using System.IO;
using Mim.Core;
using Mim.Resolvers;

namespace Mim.Validators
{
	public sealed class SchematronValidator
	{
		private readonly Stream _schematronStream;
		private readonly ResourceResolver _resolver;
		private readonly StylesheetTransformer _transformer;

		public SchematronValidator(string schematronContent, bool convertToIsoNamespace = false) : 
			this(GetSchematronContent(schematronContent, convertToIsoNamespace).GetStream())
		{
		}

		private static string GetSchematronContent(string schematronContent, bool convertToIsoNamespace) =>
			convertToIsoNamespace ? schematronContent.Replace("http://www.ascc.net/xml/schematron", "http://purl.oclc.org/dsdl/schematron")
			: schematronContent;

		public SchematronValidator(Stream schematronStream)
		{
			_schematronStream = schematronStream ?? throw new ArgumentNullException(nameof(schematronStream));
			_resolver = EmbeddedResourceResolver.Create(AssemblyType.Library);
			_transformer = new StylesheetTransformer(_resolver);
		}		
		
		public Result Validate(string inputXml) => Validate(inputXml.GetStream());		
		
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

		public static SchematronValidator Create(SchematronDocument schematronDocument) =>		
			schematronDocument switch
			{
				SchematronDocument.GenericCda => new SchematronValidator("Generic_CDA_Document_Schematron.xml".GetStreamFromAssembly()),
				SchematronDocument.TemplatedCda => new SchematronValidator("Templated_CDA_Document_Schematron.xml".GetStreamFromAssembly()),
				//SchematronDocument.TemplatedCda => new SchematronValidator("CfH_CDA_Document_Schematron.xml".GetStreamFromAssembly()), 
				SchematronDocument.PsisQuery => new SchematronValidator("PSIS_Query_Schematron.xml".GetStreamFromAssembly()),
				SchematronDocument.GenericCdaInteraction => new SchematronValidator("Generic_CDA_Interaction_Schematron.xml".GetStreamFromAssembly()),
				_ => throw new ArgumentOutOfRangeException($"{schematronDocument} has no translation")
			};	
	}

	public enum SchematronDocument
	{
		GenericCda,
		TemplatedCda,
		GenericCdaInteraction,
		PsisQuery
	}
}
