using System;
using Messaging.Validators;
using Messaging.Resolvers;
using Xunit;

namespace Messaging.Validators.Tests
{
	public class SchemaValidatorTests
	{
		private readonly IResourceResolver _localResolver;
		public SchemaValidatorTests()
		{
			_localResolver = EmbeddedResourceResolver.Create(AssemblyType.Caller);
		}

		[Theory]
		[InlineData("POCD_IN150001UK06.xsd")]
		[InlineData("POCD_IN150001UK06")]
		public void Validate_NormalCall(string filename)
		{
			var schemaValidator = new SchemaValidator(new EmbeddedResourceResolver(typeof(Mim.V6301.POCD_IN150001UK06).Assembly));
			var result =schemaValidator.Validate(filename, _localResolver.GetResourceStream("POCD_EX150001UK06_05.xml").GetText());
 
			Assert.True(result.Status);
		}


		[Fact]
		public void Validate_Failed()
		{
			var schemaValidator = new SchemaValidator(new EmbeddedResourceResolver(typeof(Mim.V6301.POCD_IN150001UK06).Assembly));
			var result = schemaValidator.Validate("POCD_IN150001UK06.xsd", _localResolver.GetResourceStream("POCD_EX150001UK06_05Invalid.xml").GetText());

			Assert.False(result.Status);
		}

	}
}
