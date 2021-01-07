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
	}
}
