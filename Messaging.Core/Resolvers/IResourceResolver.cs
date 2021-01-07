using System.IO;

namespace Messaging.Resolvers
{
	public interface IResourceResolver
	{
		Stream GetResourceStream(string filename);
	}
}
