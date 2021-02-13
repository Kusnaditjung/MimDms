using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Messaging.Resolvers
{
	/// <summary>
	/// Resource resolver is abstract class contain both XMLUrlResolver and IResourceResolver implementation
	/// </summary>
	public abstract class ResourceResolver : XmlUrlResolver, IResourceResolver
	{
		private Dictionary<string, string> _map = new Dictionary<string, string>();
		/// <summary>
		/// Resource Source name
		/// </summary>
		protected abstract string ResourceSourceName { get; }
		/// <summary>
		/// Get resource stream based on the resource name
		/// </summary>
		/// <param name="resourceName"></param>
		/// <returns></returns>
		protected abstract Stream GetResourceContent(string resourceName);

		/// <summary>
		/// Get the resource list from this source
		/// </summary>
		protected abstract string[] ResourceList { get;  }

		/// <summary>
		/// Create a map with key resourceName, and the actual resource path in the source
		/// </summary>
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

		/// <summary>
		///  Method from XMLUrlResolver to resolve an entity
		/// </summary>
		/// <param name="absoluteUri">Absolute Uri for the resource</param>
		/// <param name="role">Role</param>
		/// <param name="ofObjectToReturn">Object to return, by default this should be a stream</param>
		/// <returns></returns>
		public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) => GetResourceStream(GetFilename(absoluteUri.ToString()));

		/// <summary>
		/// This is method for IResourceResolver which resolve a resourceName to a stream
		/// </summary>
		/// <param name="resourceName">Resource name</param>
		/// <returns>Return a stream of the resource</returns>
		public Stream GetResourceStream(string resourceName)
		{
			string resourceNameNormalised;
			bool result = _map.TryGetValue(resourceName.ToLowerInvariant(), out resourceNameNormalised);

			if (!result)
				throw new InvalidOperationException($"{resourceName} cannot be found in the '{ResourceSourceName}'");

			Stream stream = GetResourceContent(resourceNameNormalised);

			if (stream == null)
				throw new InvalidOperationException($"The '{resourceName}' resource cannot be found in the '{ResourceSourceName}'");

			return stream;
		}
	}
}
