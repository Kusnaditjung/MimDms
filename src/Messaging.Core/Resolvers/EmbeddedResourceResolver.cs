using System;
using System.IO;
using System.Reflection;

namespace Messaging.Resolvers
{
	/// <summary>
	/// This class resolves resource by matching filename and extension of the embedded resources in an assembly
	/// </summary>
	public sealed class EmbeddedResourceResolver : ResourceResolver
	{
		private readonly Assembly _resourceAssembly;

		/// <summary>
		/// <see cref="EmbeddedResourceResolver"/> instance constructor
		/// </summary>
		/// <param name="resourceAssembly">Resource assembly</param>
		public EmbeddedResourceResolver(Assembly resourceAssembly = null)
		{
			_resourceAssembly = resourceAssembly ?? Assembly.GetExecutingAssembly();
			FillMap();
		}

		/// <summary>
		/// Resource source name
		/// </summary>
		protected override string ResourceSourceName => $"{_resourceAssembly.GetName().Name} assembly";
		/// <summary>
		/// List of embedded resources in the assembly
		/// </summary>
		protected override string[] ResourceList => _resourceAssembly.GetManifestResourceNames();
		
		/// <summary>
		/// Get resource content stream based on the resource name
		/// </summary>
		/// <param name="resourceName">Resourc name</param>
		/// <returns>Return a stream of the resource</returns>
		protected override Stream GetResourceContent(string resourceName) => _resourceAssembly.GetManifestResourceStream(resourceName);

		/// <summary>
		/// <see cref="EmbeddedResourceResolver"/> static constructor
		/// </summary>
		/// <param name="assemblyType">Assembly containing the embedded resources</param>
		/// <returns>Return <see cref="EmbeddedResourceResolver"/></returns>
		public static EmbeddedResourceResolver Create(AssemblyType assemblyType) =>
			assemblyType switch
			{
				AssemblyType.Caller => new EmbeddedResourceResolver(Assembly.GetCallingAssembly()),
				AssemblyType.Library => new EmbeddedResourceResolver(Assembly.GetExecutingAssembly()),
				AssemblyType.EntryHost => new EmbeddedResourceResolver(Assembly.GetEntryAssembly()),
				_ => throw new ArgumentOutOfRangeException($"No translation for {assemblyType}")
			};
		
	}

	/// <summary>
	/// Enumeration of Assembly type
	/// </summary>
	public enum AssemblyType
	{
		/// <summary>Library assembly, equivalent to Mim.Core assembly</summary>
		Library,
		/// <summary>Assembly that making the call, eg. for unit tests project </summary>
		Caller,
		/// <summary>Assembly that host the application e.g web project, desktop app, etc</summary>
		EntryHost,
	}
}
