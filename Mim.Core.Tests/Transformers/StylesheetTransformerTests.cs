using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mim.Resolvers;
using Xunit;

namespace Mim.Core.Tests.Transformers
{
	public class StylesheetTransformerTests
	{
		private ResourceResolver _unitTestAssemblyResolver;
		public StylesheetTransformerTests()
		{
			_unitTestAssemblyResolver = EmbeddedResourceResolver.Create(AssemblyType.Caller);
		}

		[Fact]
		public void Transform_UsingLibraryStylesheet_Tests()
		{
			var transformer = new StylesheetTransformer();
			var cda = _unitTestAssemblyResolver.GetResourceStream("POCD_EX150001UK06_05.xml").GetText();

			var templated = transformer.Transform(StylesheetDocument.CdaToTemplated, cda);
	

			Assert.NotNull(templated);
			Assert.True(Extensions.IsValidXml(templated));

		}

		[Fact]
		public void Transform_UsingClientStylesheet_Tests()
		{
			var transformer = new StylesheetTransformer(_unitTestAssemblyResolver);
			var localStylesheet = _unitTestAssemblyResolver.GetResourceStream("CDALikeToTrueCDA.xsl").GetText();
			var templated = transformer.Transform(localStylesheet, _unitTestAssemblyResolver.GetResourceStream("POCD_EX150001UK06_05.xml").GetText());

			Assert.NotNull(templated);
			Assert.True(Extensions.IsValidXml(templated));
		}
	}
}
