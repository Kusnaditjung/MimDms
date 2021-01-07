using System;
using System.IO;

namespace Mim.Resolvers
{
	public sealed class DirectoryResourceResolver : ResourceResolver
	{
		private readonly string _path;
		public DirectoryResourceResolver(string path)
		{
			_path = path ?? throw new ArgumentNullException(nameof(path));
			FillMap();
		}
		protected override string ResourceSourceName => $"{_path} directory";
		protected override string[] ResourceList => Directory.GetFiles(_path, "*.*", SearchOption.AllDirectories);
		protected override Stream GetResourceContent(string resourceName) => new StreamReader(resourceName).BaseStream;
	}
}
