using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Xsl;

namespace Mim
{
	public static class Transformation
	{
        public static Result ValidateSchematron(SchematronType scematronType, string xml)
        {
            var result = Transform(GetSchematron(scematronType), xml);

            if (string.IsNullOrWhiteSpace(result))
			{
                return Result.Success();
			}
            else
			{
                return Result.Error(result);
			}
        }

        public static string Transform(TransformType transformType, string xml) => Transform(GetStylesheetXml(transformType), xml);
        
        private static string Transform(string stylesheetXml, string inputXml)
		{
            using (var stylesheetReader = new StringReader(stylesheetXml))
            {
               var settings = new XmlReaderSettings
                {
                    DtdProcessing = DtdProcessing.Parse,
                    ValidationType = ValidationType.Schema                
                };

                using (var styleXmlReader = XmlReader.Create(stylesheetReader, settings))
                {
                    XslCompiledTransform compiledTransformation = new XslCompiledTransform();
                    compiledTransformation.Load(styleXmlReader);

                    using (var inputReader = new StringReader(inputXml))
                    {
                        using (var inputXmlReader = XmlReader.Create(inputReader))
                        {
                            using (var memStream = new MemoryStream())
                            {
                                using (var writer = new XmlTextWriter(memStream, Encoding.UTF8))
                                {
                                    compiledTransformation.Transform(inputXmlReader, null, writer);
                                }

                                return Encoding.UTF8.GetString(memStream.ToArray());
                            }
                        }
                    }
                }
            }            
        }      
		
        private static string GetStylesheetXml(TransformType transformType)
		{

            var assembly = typeof(Transformation).Assembly;
            Stream stream = null;
            switch(transformType)
			{
                case TransformType.WireToTemplated:
                    var b = assembly.GetManifestResourceNames();
                    stream = assembly.GetManifestResourceStream($"Mim.Core.Resources.Transforms.TrueCDAToCDALike.xsl");
                    break;
                case TransformType.TemplatedToWire:
                    stream = assembly.GetManifestResourceStream($"Mim.Core.Resources.Transforms.CDALikeToTrueCDA.xsl");
                    break;
                case TransformType.GenericRenderer:
                    stream = assembly.GetManifestResourceStream($"Mim.Core.Resources.Transforms.CDA_NPfIT_Document_Renderer.xsl"); 
                    break;
                case TransformType.Nhs111PrimaryRenderer:
                    stream = stream = assembly.GetManifestResourceStream($"Mim.Core.Resources.Transforms.IntegratedUrgentCare_CDA_Renderer_PrimaryRecipients.xslt");
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"{transformType} has no associated stylesheet");
            }

            using(stream)
			{
               using(StreamReader sr = new StreamReader(stream))
				{
                    return sr.ReadToEnd();
				}
			}
		}

        private static string GetSchematron(SchematronType schematronType)
        {

            var assembly = typeof(SchematronType).Assembly;
            Stream stream = null;
            switch (schematronType)
            {
                case SchematronType.CfHCDA:
                    stream = assembly.GetManifestResourceStream($"Mim.Core.Resources.Schematrons.CfH_CDA_Document_Schematron.xml");
                    break;
                case SchematronType.GenericCDA:
                    stream = assembly.GetManifestResourceStream($"Mim.Core.Resources.Schematrons.Generic_CDA_Document_Schematron.xml");
                    break;
                case SchematronType.CDACRETypes:
                    stream = assembly.GetManifestResourceStream($"Mim.Core.Resources.Schematrons.CRE_Types.xml");
                    break;
                case SchematronType.GenericCDAInteraction:
                    stream = stream = assembly.GetManifestResourceStream($"Mim.Core.Resources.Schematrons.Generic_CDA_Interaction_Schematron.xml");
                    break;
                case SchematronType.PSISQuery:
                    stream = stream = assembly.GetManifestResourceStream($"Mim.Core.Resources.Schematrons.PSIS_Query_Schematron.xml");
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"{schematronType} has no associated schematron file");
            }

            using (stream)
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    return sr.ReadToEnd();
                }
            }
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
		Nhs111PrimaryRenderer
	}   

