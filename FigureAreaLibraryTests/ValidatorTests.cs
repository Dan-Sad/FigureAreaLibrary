using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureAreaLibrary.Tests
{
	[TestClass()]
	public class ValidatorTests
	{
		[TestMethod]
		public void NotNanMoreZero_Value100_True()
		{
			double value = 100;

			var result = Validator.NotNanMoreZero(value);

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void NotNanMoreZero_ValueNaN_False()
		{
			double value = double.NaN;

			var result = Validator.NotNanMoreZero(value);

			Assert.IsFalse(result);
		}

		[TestMethod]
		public void NotNanMoreZero_Value0_False()
		{
			double value = 0;

			var result = Validator.NotNanMoreZero(value);

			Assert.IsFalse(result);
		}

		[TestMethod]
		public void NotNanMoreZero_ValueMinus10_False()
		{
			double value = -10;

			var result = Validator.NotNanMoreZero(value);

			Assert.IsFalse(result);
		}
	}
}