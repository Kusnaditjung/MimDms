using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using Mim.Resolvers;
using static Mim.Core.Extensions;

namespace Mim
{
	public sealed class StylesheetTransformer
	{
        private readonly ResourceResolver _resolver;
        public StylesheetTransformer(ResourceResolver resolver = null)
		{
            _resolver = resolver == null
               ? new EmbeddedResourceResolver()
               : resolver;
		}

        public string Transform(StylesheetDocument stylesheetDocument, string inputXml)
        {
            var s = GetStylesheetStream(stylesheetDocument).GetText();
            using var stylesheetStream = s.GetStream();
            using var inputXmlStream = inputXml.GetStream();
            using var result = TransformStream(stylesheetStream, inputXmlStream);
            return result.GetText();
        }

        public string Transform(string stylesheetXml, string inputXml)
        {
            using var stylesheetStream = stylesheetXml.GetStream();
            using var inputXmlStream = inputXml.GetStream();
            using var result = TransformStream(stylesheetStream, inputXmlStream);

            return result.GetText();            
        }      

        public Stream TransformStream(Stream stylesheetStream, Stream inputXmlStream)
		{           
            var settings = new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Parse,
                ValidationType = ValidationType.Schema     
            };

            using var styleXmlReader = XmlReader.Create(stylesheetStream, settings);
            
            XslCompiledTransform compiledTransformation = new XslCompiledTransform();
            compiledTransformation.Load(styleXmlReader, null, _resolver);
                    
            using var inputXmlReader = XmlReader.Create(inputXmlStream);
            using var memStream = new MemoryStream();
            using var writer = new XmlTextWriter(memStream, Encoding.UTF8);
            compiledTransformation.Transform(inputXmlReader, null, writer);

            return new MemoryStream(memStream.ToArray());
        }

        private Stream GetStylesheetStream(StylesheetDocument stylesheetDocument) =>
            stylesheetDocument switch
            {
                StylesheetDocument.CdaToTemplated => _resolver.GetResourceStream("TrueCDAToCDALike.xsl"),
                StylesheetDocument.TemplatedToCda => _resolver.GetResourceStream("CDALikeToTrueCDA.xsl"),
                StylesheetDocument.CdaRenderer => _resolver.GetResourceStream("CDA_NPfIT_Document_Renderer.xsl"),
                StylesheetDocument.Nhs111PrimaryCdaRenderer => _resolver.GetResourceStream("IntegratedUrgentCare_CDA_Renderer_PrimaryRecipients.xslt"),
                StylesheetDocument.PostConversion => _resolver.GetResourceStream("postTxReorder.xslt"),
                _ => throw new ArgumentOutOfRangeException($"'{stylesheetDocument}' has no an associated stylesheet")
            };		     
    }

    public enum StylesheetDocument
    {
        CdaToTemplated,
        TemplatedToCda,
        CdaRenderer,
        Nhs111PrimaryCdaRenderer,
        PostConversion,
    }
}



