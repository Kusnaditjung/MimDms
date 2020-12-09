using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

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

		


		public static Result ValidateSchema(Type type, string xml) =>
			ValidateSchema(type.Assembly, type.Name, xml);


		public static Result ValidateSchema(string schemaFolder, string schemaTypeName, string xml)
		{
			var fileResolver = new FileResolver(schemaFolder);
			return ValidateByResolver(schemaTypeName, fileResolver);
		}

		public static Result ValidateSchema(Assembly assembly, string schemaTypeName, string xml)
		{
			var embeddedResourceResolver = new EmbeddedResourceResolver(assembly);
			return ValidateByResolver(schemaTypeName, embeddedResourceResolver);
		}

		private static Result ValidateByResolver(string schemaTypeName, XmlResolver resolver)
		{
			string errorMessage = string.Empty;
			Exception errorException = null;

			var settings = new XmlReaderSettings
			{
				ValidationType = ValidationType.Schema,
				Schemas = new XmlSchemaSet
				{
					XmlResolver = resolver
				}				
			};

			settings.ValidationEventHandler += (s, e) => 
			{
				if (e.Severity == XmlSeverityType.Error)
				{
					errorMessage = e.Message;
					errorException = e.Exception;
				}
			}; 

			using (Stream input = (Stream)resolver.GetEntity(new Uri($"C://{schemaTypeName}.xsd"), null, typeof(Stream)))
			{
				XmlReader reader = XmlReader.Create(input, settings);

				while (reader.Read()) ;
			}

			return errorMessage != string.Empty
				? Result.ErrorAndException(errorMessage, errorException)
				: Result.Success();				
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

		private class EmbeddedResourceResolver : XmlUrlResolver
		{
			private static object _sync = new object();
			private static Dictionary<string, Dictionary<string, string>> _dict = new Dictionary<string, Dictionary<string, string>>();
			private readonly Assembly _resourceAssembly;
			private readonly Dictionary<string, string> _map;

			public EmbeddedResourceResolver(Assembly resourceAssembly)
			{
				if (resourceAssembly == null)
					throw new ArgumentNullException("resourceAssembly must not be null");

				_resourceAssembly = resourceAssembly;
				var resourceName = resourceAssembly.GetName().Name;
				if (!_dict.ContainsKey(resourceName))
				{
					lock (_sync)
					{
						if (!_dict.ContainsKey(resourceName))
						{
							var map = new Dictionary<string, string>();
							foreach (var res in resourceAssembly.GetManifestResourceNames())
							{
								var parts = res.Split('.');
								if (parts[parts.Length - 1].ToLowerInvariant() == "xsd")
								{
									var key = $"{parts[parts.Length - 2]}.{parts[parts.Length - 1]}";
									map.Add(key.ToLowerInvariant(), res);
								}
							}

							_dict.Add(resourceName, map);
						}
					}
				}

				_dict.TryGetValue(resourceName, out _map);
			}

			public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
			{
				if (absoluteUri.IsFile)
				{
					string assemblyName = _resourceAssembly.GetName().Name;
					string file = Path.GetFileName(absoluteUri.ToString());
					string resourceName;
					bool result = _map.TryGetValue(file.ToLowerInvariant(), out resourceName); 
					
					if (!result)
					{
						throw new InvalidOperationException($"{file} cannot be found in the '{assemblyName}' assembly's embedded resources");
					}

					Stream stream = _resourceAssembly.GetManifestResourceStream(resourceName);					   

					if (stream == null)
					{
						throw new InvalidOperationException($"Embedded resource '{file}' in the '{_resourceAssembly.GetName().Name}' assembly cannot be loaded");
					}

					return stream;
				}
				else
				{
					throw new InvalidOperationException($"Cannot process a non-file reference '{absoluteUri}' in the schema");
				}				
			}
		}


		private class FileResolver : XmlUrlResolver
		{
			private static object _sync = new object();
			private static Dictionary<string, Dictionary<string, string>> _dict = new Dictionary<string, Dictionary<string, string>>();
			private readonly string _path;
			private readonly Dictionary<string, string> _map;

			public FileResolver(string path)
			{
				if (path == null)
					throw new ArgumentNullException("path");

				_path = path;
				
				if (!_dict.ContainsKey(_path))
				{
					lock (_sync)
					{
						if (!_dict.ContainsKey(_path))
						{
							var map = new Dictionary<string, string>();

							foreach (var fileFullName in GetAllFiles())
							{
								if (Path.GetExtension(fileFullName).ToLowerInvariant() == ".xsd")
								{
									var file = Path.GetFileName(fileFullName);
									map.Add(file.ToLowerInvariant(), fileFullName);
								}
							}

							_dict.Add(_path, map);
						}
					}
				}

				_dict.TryGetValue(_path, out _map);
			}

			private IEnumerable<string> GetAllFiles()
			{
				return Directory.GetFiles(_path, "*.*", SearchOption.AllDirectories);
			}

			public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
			{
				if (absoluteUri.IsFile)
				{
					string file = Path.GetFileName(absoluteUri.ToString());
					string fileFullPath;
					bool result = _map.TryGetValue(file.ToLowerInvariant(), out fileFullPath);

					if (!result)
					{
						throw new InvalidOperationException($"{file} cannot be found in the '{_path}' directory");
					}

					try
					{
						return new StreamReader(fileFullPath).BaseStream;
					}
					catch (IOException e)
					{
						throw new InvalidOperationException($"Cannot read '{file}' in the '{_path}' directory. Exception : {e.Message}");
					}					
				}
				else
				{
					throw new InvalidOperationException($"Cannot process a non-file reference '{absoluteUri}' in the schema");
				}
			}
		}
	}
}
