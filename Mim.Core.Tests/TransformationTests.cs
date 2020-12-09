using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mim.Core.Tests
{
	[TestClass]
	public class TransformationTests
	{
		[TestMethod]
		public void ValidateSchematron_NormalCall()
		{
			var res = Transformation.ValidateSchematron(SchematronType.GenericCDA, Properties.Resources.POCD_EX150001UK06_05);
			Assert.IsTrue(res.Status);
		}
	}
}
