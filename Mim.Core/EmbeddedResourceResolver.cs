using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Mim
{
	public class EmbeddedResourceResolver : XmlUrlResolver
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
}
