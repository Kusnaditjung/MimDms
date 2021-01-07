using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Mim.Resolvers
{
	public abstract class ResourceResolver : XmlUrlResolver, IResourceResolver
	{
		private Dictionary<string, string> _map = new Dictionary<string, string>();
		protected abstract string ResourceSourceName { get; }
		protected abstract Stream GetResourceContent(string resourceName);
		protected abstract string[] ResourceList { get;  }
		protected void FillMap()
		{
			foreach (var res in ResourceList)
			{
				var key = GetFilename(res).ToLowerInvariant();

				if (_map.ContainsKey(key))
					throw new InvalidOperationException($"There are multiple filenames '{key}' in the '{ResourceSourceName}'");

				_map.Add(key, res);
			}
		}

		private string GetFilename(string name)
		{
			var parts = name.Split(new char[] { '.', '\\', '/' }, StringSplitOptions.RemoveEmptyEntries);
			return $"{parts[parts.Length - 2]}.{parts[parts.Length - 1]}";
		}

		public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) => GetResourceStream(GetFilename(absoluteUri.ToString()));

		public Stream GetResourceStream(string filename)
		{
			string resourceName;
			bool result = _map.TryGetValue(filename.ToLowerInvariant(), out resourceName);

			if (!result)
				throw new InvalidOperationException($"{filename} cannot be found in the '{ResourceSourceName}'");

			Stream stream = GetResourceContent(resourceName);

			if (stream == null)
				throw new InvalidOperationException($"The '{filename}' resource cannot be found in the '{ResourceSourceName}'");

			return stream;
		}
	}
}
