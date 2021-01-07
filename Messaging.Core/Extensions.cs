using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Messaging.Validators;
using Messaging.Resolvers;

namespace Messaging
{
	public static class Extensions
	{
		public static string GetText(this Stream stream) => new StreamReader(stream).ReadToEnd();

		public static Stream GetStream(this string content) => new MemoryStream(UTF8Encoding.UTF8.GetBytes(content));

		public static Stream GetStreamFromAssembly(this string filename) => EmbeddedResourceResolver.Create(AssemblyType.Library).GetResourceStream(filename);

		public static string MakeSureHasSchemaExtension(this string filename) =>
			Path.HasExtension(filename) ? filename
			: filename + ".xsd";


		public static bool IsValidXml(string xml)
		{
			try
			{
				XDocument xd1 = new XDocument();
				xd1 = XDocument.Load(xml.GetStream());
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
