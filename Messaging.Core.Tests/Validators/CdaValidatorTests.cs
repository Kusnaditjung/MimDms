using Messaging.Validators;
using Messaging.Resolvers;
using Xunit;

namespace Messaging.Validators.Tests
{
	public class CdaValidatorTests
	{
		private IResourceResolver _fileResolver;
		public CdaValidatorTests()
		{
			_fileResolver = EmbeddedResourceResolver.Create(AssemblyType.Caller);
		}

		[Fact]
		public void Validate_NormalCall()
		{
			var cdaValidator = new CdaValidator(new EmbeddedResourceResolver(typeof(Mim.V6301.POCD_MT000001UK04Act).Assembly));
			Result result = cdaValidator.Validate(_fileResolver.GetResourceStream("POCD_EX150001UK06_05.xml").GetText());
			Assert.True(result.Status);
		}

		[Fact]
		public void Validate_SpecifyingTemplateName_NormalCall()
		{
			var cdaValidator = new CdaValidator(new EmbeddedResourceResolver(typeof(Mim.V6301.POCD_MT000001UK04Act).Assembly));
			Result result = cdaValidator.Validate(_fileResolver.GetResourceStream("POCD_EX150001UK06_05.xml").GetText(), Mim.V6301.SchemaNames.POCD_MT150001UK06.ToString());
			Assert.True(result.Status);
		}
	}
}
