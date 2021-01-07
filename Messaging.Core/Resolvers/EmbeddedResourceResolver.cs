using System;
using System.IO;
using System.Reflection;

namespace Messaging.Resolvers
{
	/// <summary>This class resolves resource by matching filename and extension of the embedded resources in an assembly
	/// </summary>
	public sealed class EmbeddedResourceResolver : ResourceResolver
	{
		private readonly Assembly _resourceAssembly;
		public EmbeddedResourceResolver(Assembly resourceAssembly = null)
		{
			_resourceAssembly = resourceAssembly ?? Assembly.GetExecutingAssembly();
			FillMap();
		}
		protected override string ResourceSourceName => $"{_resourceAssembly.GetName().Name} assembly";
		protected override string[] ResourceList => _resourceAssembly.GetManifestResourceNames();
		protected override Stream GetResourceContent(string resourceName) => _resourceAssembly.GetManifestResourceStream(resourceName);

		public static EmbeddedResourceResolver Create(AssemblyType assemblyType) =>
			assemblyType switch
			{
				AssemblyType.Caller => new EmbeddedResourceResolver(Assembly.GetCallingAssembly()),
				AssemblyType.Library => new EmbeddedResourceResolver(Assembly.GetExecutingAssembly()),
				AssemblyType.EntryHost => new EmbeddedResourceResolver(Assembly.GetEntryAssembly()),
				_ => throw new ArgumentOutOfRangeException($"No translation for {assemblyType}")
			};

		public static EmbeddedResourceResolver Create(Assembly externalAssembly)
		{
			if (externalAssembly == null) throw new ArgumentNullException(nameof(externalAssembly));

			return new EmbeddedResourceResolver(externalAssembly);
		}
	}

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
