using System;
using System.IO;

namespace Messaging.Resolvers
{
	/// <summary>
	/// DirectoryResourceResolver is resource resolver which use a directory in the disk as a source
	/// </summary>
	public sealed class DirectoryResourceResolver : ResourceResolver
	{
		private readonly string _path;
		
		/// <summary>
		/// <see cref="DirectoryResourceResolver"/> instance constructor
		/// </summary>
		/// <param name="path">directory on disk/volume to be used as source</param>
		public DirectoryResourceResolver(string path)
		{
			_path = path ?? throw new ArgumentNullException(nameof(path));
			FillMap();
		}

		/// <summary>
		/// Resource Source name
		/// </summary>
		protected override string ResourceSourceName => $"{_path} directory";
		
		/// <summary>
		/// List of resources in that directory, including all subdirectories's files
		/// </summary>
		protected override string[] ResourceList => Directory.GetFiles(_path, "*.*", SearchOption.AllDirectories);
		
		/// <summary>
		/// Get resource content based on the resource name
		/// </summary>
		/// <param name="resourceName">Resource name</param>
		/// <returns>Return a stream for the resource</returns>
		protected override Stream GetResourceContent(string resourceName) => new StreamReader(resourceName).BaseStream;
	}
}
