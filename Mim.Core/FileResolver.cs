using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Mim
{
	public class FileResolver : XmlUrlResolver
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
