using FigureAreaLibrary;

namespace FigureAreaLibraryTest
{
	[TestClass]
	public class UnitTestCircle
	{
		[TestMethod]
		public void Circle_When_Radius10_Then_Radius10()
		{
			//Arrange 
			int radius = 10;
			int expected = 10;

			//Act
			var circle = new Circle(radius);

			//Assert
			Assert.IsNotNull(circle);
			Assert.AreEqual(expected, circle.Radius);
		}

		[TestMethod]
		public void Circle_When_Radius0_Then_Radius0()
		{
			//Arrange 
			int radius = 0;
			int expected = 0;

			//Act
			var circle = new Circle(radius);

			//Assert
			Assert.IsNotNull(circle);
			Assert.AreEqual(expected, circle.Radius);
		}

		[TestMethod]
		public void Circle_When_RadiusMinus10_Then_Radius0()
		{
			//Arrange 
			int radius = -10;
			int expected = 0;

			//Act
			var circle = new Circle(radius);

			//Assert
			Assert.IsNotNull(circle);
			Assert.AreEqual(expected, circle.Radius);
		}

		[TestMethod]
		public void Circle_When_RadiusMinus10_Then_Radius0()
		{
			//Arrange 
			int radius = -10;
			int expected = 0;

			//Act
			var circle = new Circle(radius);

			//Assert
			Assert.IsNotNull(circle);
			Assert.AreEqual(expected, circle.Radius);
		}
	}
}