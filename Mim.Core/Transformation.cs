using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using static Mim.Core.Extensions;

namespace Mim
{
	public static class Transformation
	{
        public static Result ValidateSchematron(SchematronType scematronType, string inputXml)
		{
			var schematronStream = GetSchematronText(scematronType);

			var inputXmlStream = inputXml.CreateTextStream();

			using var isoSchematronStream = IsoSchematronTransform(schematronStream);
			var result = TransformStream(isoSchematronStream, inputXmlStream).GetText();

			return string.IsNullOrWhiteSpace(result) ? Result.Success()
				: Result.Error(result);
		}

		private static Stream IsoSchematronTransform(Stream inputXmlStream)
		{
			var output = IsoTransform(GetStylesheetStream(TransformType.IsoDsdlInclude), inputXmlStream);
            var t = output.GetText();
            output = IsoTransform(GetStylesheetStream(TransformType.IsoSchematronText), output);
			return  IsoTransform(GetStylesheetStream(TransformType.IsoSchematronText), output);
		}

		public static string Transform(TransformType transformType, string xml) => 
            TransformStream(
                stylesheetStream: GetStylesheetStream(transformType), 
                inputXmlStream: xml.CreateTextStream())
            .GetText();

        public static string Transform(string stylesheetXml, string inputXml)
        {
            using var stylesheetStream = stylesheetXml.CreateTextStream();
            using var inputXmlStream = inputXml.CreateTextStream();
            return TransformStream(stylesheetStream, inputXmlStream).GetText();            
        }      

        public static Stream TransformStream(Stream stylesheetStream, Stream inputXmlStream)
		{           
            var settings = new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Parse,
                ValidationType = ValidationType.Schema                
            };

            using (var styleXmlReader = XmlReader.Create(stylesheetStream, settings))
            {
                XslCompiledTransform compiledTransformation = new XslCompiledTransform();
                compiledTransformation.Load(styleXmlReader);
                    
                using var inputXmlReader = XmlReader.Create(inputXmlStream);
                var memStream = new MemoryStream();
                using var writer = new XmlTextWriter(memStream, Encoding.UTF8);
                compiledTransformation.Transform(inputXmlReader, null, writer);
                memStream.Position = 0;
                return memStream;                   
            }                      
        }

		private static Stream IsoTransform(Stream IsoSchematronStream,  Stream inputStream)
		{
			XPathDocument inputDoc = new XPathDocument(inputStream);

			XPathDocument transformDoc = new XPathDocument(IsoSchematronStream);
			XslCompiledTransform transform = new XslCompiledTransform();
			transform.Load(transformDoc, null, new EmbeddedResourceResolver(typeof(TransformType).Assembly));

            MemoryStream output = new MemoryStream();
			transform.Transform(inputDoc, null, output);

            return output;
		}

		private static Stream GetStylesheetStream(TransformType transformType)
		{
            var assembly = typeof(Transformation).Assembly;
            switch(transformType)
			{
                case TransformType.WireToTemplated:
                    return assembly.GetManifestResourceStream($"Mim.Core.Resources.Transforms.TrueCDAToCDALike.xsl");
                case TransformType.TemplatedToWire:
                    return assembly.GetManifestResourceStream($"Mim.Core.Resources.Transforms.CDALikeToTrueCDA.xsl");
                case TransformType.GenericRenderer:
                    return assembly.GetManifestResourceStream($"Mim.Core.Resources.Transforms.CDA_NPfIT_Document_Renderer.xsl"); 
                case TransformType.Nhs111PrimaryRenderer:
                    return assembly.GetManifestResourceStream($"Mim.Core.Resources.Transforms.IntegratedUrgentCare_CDA_Renderer_PrimaryRecipients.xslt");
                case TransformType.IsoAbstractExpand:
                    return assembly.GetManifestResourceStream($"Mim.Core.Resources.Transforms.Iso.iso_abstract_expand.xsl");
                case TransformType.IsoDsdlInclude:
                    return  assembly.GetManifestResourceStream($"Mim.Core.Resources.Transforms.Iso.iso_dsdl_include.xsl");
                case TransformType.IsoSchematronSkeletonForXslt1:
                    return assembly.GetManifestResourceStream($"Mim.Core.Resources.Transforms.Iso.iso_schematron_skeleton_for_xslt1.xsl");
                case TransformType.IsoSchematronText:
                    return assembly.GetManifestResourceStream($"Mim.Core.Resources.Transforms.Iso.iso_schematron_text.xsl");
                case TransformType.IsoSvrlForXslt1:
                    return assembly.GetManifestResourceStream($"Mim.Core.Resources.Transforms.Iso.iso_svrl_for_xslt1.xsl");
                default:
                    throw new ArgumentOutOfRangeException($"{transformType} has no associated stylesheet");
            }
		}

        private static Stream GetSchematronText(SchematronType schematronType)
        {

            var assembly = typeof(SchematronType).Assembly;
            switch (schematronType)
            {
                case SchematronType.CfHCDA:
                    return assembly.GetManifestResourceStream($"Mim.Core.Resources.Schematrons.CfH_CDA_Document_Schematron.xml");
                case SchematronType.GenericCDA:
                    return assembly.GetManifestResourceStream($"Mim.Core.Resources.Schematrons.Generic_CDA_Document_Schematron.xml");
                case SchematronType.GenericCDAInteraction:
                    return assembly.GetManifestResourceStream($"Mim.Core.Resources.Schematrons.Generic_CDA_Interaction_Schematron.xml");
                case SchematronType.PSISQuery:
                    return  assembly.GetManifestResourceStream($"Mim.Core.Resources.Schematrons.PSIS_Query_Schematron.xml");
                default:
                    throw new ArgumentOutOfRangeException($"{schematronType} has no associated schematron file");
            }
        }
    }

    public enum SchematronType
    {
        CfHCDA,
        CDACRETypes,
        GenericCDA,
        GenericCDAInteraction,
        PSISQuery
    }

    public enum TransformType
    {
        WireToTemplated,
        TemplatedToWire,
        GenericRenderer,
        Nhs111PrimaryRenderer,
        IsoAbstractExpand,
        IsoDsdlInclude,
        IsoSchematronSkeletonForXslt1,
        IsoSchematronText,
        IsoSvrlForXslt1
    }
}



