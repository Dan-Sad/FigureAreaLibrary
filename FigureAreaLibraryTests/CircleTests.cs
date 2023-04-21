using FigureAreaLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureAreaLibrary.Tests
{
	[TestClass()]
	public class CircleTests
	{
		[TestMethod]
		public void Circle_Radius10_CircleRadius10()
		{
			double radius = 10;
			double expected = 10;

			var circle = new Circle(radius);

			Assert.AreEqual(expected, circle.Radius);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Circle_RadiusMinus10_ArgumentException()
		{
			double radius = -10;
			new Circle(radius);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Circle_Radius0_ArgumentException()
		{
			double radius = 0;
			new Circle(radius);
		}

		[TestMethod]
		public void Area_Radius10_Area314dot1592653589793()
		{
			double radius = 10;
			double expected = 314.1592653589793;

			var circle = new Circle(radius);
			double area = circle.Area();

			Assert.AreEqual(expected, area);
		}
	}
}