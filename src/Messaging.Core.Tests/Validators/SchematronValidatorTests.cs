using System;
using Messaging.Resolvers;
using Messaging.Validators;
using Xunit;

namespace Messaging.Validators.Tests
{
	public class SchematronValidatorTests
	{
		private IResourceResolver _fileResolver;

		public SchematronValidatorTests()
		{
			_fileResolver = EmbeddedResourceResolver.Create(AssemblyType.Caller);
		}

		[Theory]
		[InlineData("POCD_EX150001UK06_05.xml", true)]
		[InlineData("POCD_EX150001UK06_05Invalid.xml", false)]
		public void Validate_IsoDocument_OnStream(string filename, bool result)
		{
			var res = SchematronValidator.Create(SchematronDocument.GenericCda).Validate(_fileResolver.GetResourceStream(filename));
			Assert.Equal(result, res.Status);
		}

		[Theory]
		[InlineData("POCD_EX150001UK06_05.xml", true)]
		[InlineData("POCD_EX150001UK06_05Invalid.xml", false)]
		public void Validate_IsoDocument_OnText(string filename, bool result)
		{
			var res = SchematronValidator.Create(SchematronDocument.GenericCda).Validate(_fileResolver.GetResourceStream(filename).GetText());
			Assert.Equal(result, res.Status);
		}

		[Fact]
		public void Validate_NonIsoDocument_OnStream()
		{
			string nonIsoDocument = _fileResolver.GetResourceStream("Generic_CDA_Document_OldSchematron.xml").GetText();
			var res = new SchematronValidator(nonIsoDocument, convertToIsoNamespace: true).Validate(_fileResolver.GetResourceStream("POCD_EX150001UK06_05.xml"));
			Assert.True(res.Status);
		}

		[Fact]
		public void Validate_NonIsoDocument_OnText()
		{
			string nonIsoDocument = _fileResolver.GetResourceStream("Generic_CDA_Document_OldSchematron.xml").GetText();
			var res = new SchematronValidator(nonIsoDocument, convertToIsoNamespace: true).Validate(_fileResolver.GetResourceStream("POCD_EX150001UK06_05.xml").GetText());
			Assert.True(res.Status);
		}
	}
}
