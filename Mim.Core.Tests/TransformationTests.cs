using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mim.Core.Tests
{
	public class TransformationTests
	{
		[Fact]
		public void ValidateSchematron_NormalCall()
		{
			var res = Transformation.ValidateSchematron(SchematronType.GenericCDA, Properties.Resources.POCD_EX150001UK06_05);
			Assert.True(res.Status);
		}
	}
}
