using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using Messaging.Resolvers;
using static Messaging.Extensions;

namespace Messaging.Transformers
{
    /// <summary>
    /// StylesheetTransformer is the stylesheet transformer
    /// </summary>
	public sealed class StylesheetTransformer
	{
        private readonly ResourceResolver _resolver;

        /// <summary>
        /// <see cref="StylesheetTransformer"/> instance constructor
        /// </summary>
        /// <param name="resolver">Resource resolver, used to resolve any reference in the stylesheet content</param>
        public StylesheetTransformer(ResourceResolver resolver = null)
		{
            _resolver = resolver == null
               ? new EmbeddedResourceResolver()
               : resolver;
		}

        /// <summary>
        /// Transform input XML using an enumerated stylessheet document contained in the Messaging.Core
        /// </summary>
        /// <param name="stylesheetDocument">Enumerated stylesheet content</param>
        /// <param name="inputXml">input XML</param>
        /// <returns>Return a transformed XML</returns>
        public string Transform(StylesheetDocument stylesheetDocument, string inputXml)
        {
            var s = GetStylesheetStream(stylesheetDocument).GetText();
            using var stylesheetStream = s.GetStream();
            using var inputXmlStream = inputXml.GetStream();
            using var result = TransformStream(stylesheetStream, inputXmlStream);
            return result.GetText();
        }

        /// <summary>
        /// Transform inputXML based on an stylesheet XML
        /// </summary>
        /// <param name="stylesheetXml">Stylesheet XML</param>
        /// <param name="inputXml">input XML</param>
        /// <returns></returns>
        public string Transform(string stylesheetXml, string inputXml)
        {
            using var stylesheetStream = stylesheetXml.GetStream();
            using var inputXmlStream = inputXml.GetStream();
            using var result = TransformStream(stylesheetStream, inputXmlStream);

            return result.GetText();            
        }      

        /// <summary>
        /// Transform input stream using a stylesheet stream
        /// </summary>
        /// <param name="stylesheetStream">stylesheet stream</param>
        /// <param name="inputXmlStream">input XML stream</param>
        /// <returns>Return a transformed stream</returns>
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

    /// <summary>
    /// Enumerated stylesheet content
    /// </summary>
    public enum StylesheetDocument
    {
        /// <summary>
        /// Transform a generic CDA to templated CDA message
        /// </summary>
        CdaToTemplated,
        /// <summary>
        /// Transform a templated CDA to a generic CDA message
        /// </summary>
        TemplatedToCda,
        /// <summary>
        /// Transform a generic CDA to viewable HTML
        /// </summary>
        CdaRenderer,
        /// <summary>
        /// Transform a generic CDA to viewable HTML for NHS 111 primary recipient
        /// </summary>
        Nhs111PrimaryCdaRenderer,
        /// <summary>
        /// Transform a generic CDA or templated CDA after the conversion
        /// </summary>
        PostConversion,
    }
}



