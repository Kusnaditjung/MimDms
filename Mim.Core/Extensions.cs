using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mim.Core
{
	public static class Extensions
	{
		public static string GetText(this Stream stream) => new StreamReader(stream).ReadToEnd();

		public static Stream CreateTextStream(this string content) => new MemoryStream(UTF8Encoding.UTF8.GetBytes(content));
	}
}
