using System.IO;

namespace Mim.Resolvers
{
	public interface IResourceResolver
	{
		Stream GetResourceStream(string filename);
	}
}
