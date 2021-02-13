using System;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Messaging.Resolvers;

namespace Messaging
{
	/// <summary>
	/// Extension methods to support usage of validator and transformer
	/// </summary>
	public static class Extensions
	{
		/// <summary>
		/// Used to convert a stream to text representation
		/// </summary>
		/// <param name="stream">Stream input</param>
		/// <returns>Return the equivalent text</returns>
		public static string GetText(this Stream stream) => new StreamReader(stream).ReadToEnd();

		/// <summary>
		/// Used to convert from string to stream representation
		/// </summary>
		/// <param name="content">input in text representation</param>
		/// <returns>Return the equivalent stream</returns>
		public static Stream GetStream(this string content) => new MemoryStream(UTF8Encoding.UTF8.GetBytes(content));

		/// <summary>
		/// Get stream from embedded resource in the current code assembly
		/// </summary>
		/// <param name="resourceName"></param>
		/// <returns></returns>
		public static Stream GetStreamFromAssembly(this string resourceName) => EmbeddedResourceResolver.Create(AssemblyType.Library).GetResourceStream(resourceName);

		/// <summary>
		/// Check filename, if it does not have extension append with xsd extension
		/// </summary>
		/// <param name="filename">Filename</param>
		/// <returns>Return filename with xsd extension</returns>
		public static string MakeSureHasSchemaExtension(this string filename) =>
			Path.HasExtension(filename) ? filename
			: filename + ".xsd";


		/// <summary>
		/// Check if xml is a valid XML content
		/// </summary>
		/// <param name="xml">input XML</param>
		/// <returns>Return true or false</returns>
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
