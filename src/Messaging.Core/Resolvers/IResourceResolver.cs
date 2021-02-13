using System.IO;

namespace Messaging.Resolvers
{
	/// <summary>
	/// Interface for resource resolver
	/// </summary>
	public interface IResourceResolver
	{
		/// <summary>
		/// Signature to retrieve a stream from a resource name
		/// </summary>
		/// <param name="resourceName"></param>
		/// <returns></returns>
		Stream GetResourceStream(string resourceName);
	}
}
