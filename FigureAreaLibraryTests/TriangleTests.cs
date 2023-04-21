using FigureAreaLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureAreaLibrary.Tests
{
	[TestClass]
	public class TriangleTests
	{
		[TestMethod]
		public void Triangle_When_Sides10_11_12_Then_TriangleSides10_11_12()
		{
			double sideA = 10;
			double sideB = 11;
			double sideC = 12;
			double expectedSideA = 10;
			double expectedSideB = 11;
			double expectedSideC = 12;

			var triangle = new Triangle(sideA, sideB, sideC);

			Assert.AreEqual(expectedSideA, triangle.SideA);
			Assert.AreEqual(expectedSideB, triangle.SideB);
			Assert.AreEqual(expectedSideC, triangle.SideC);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Triangle_OneOfSideIsZero_ArgumentException()
		{
			double sideA = 10;
			double sideB = 20;
			double sideC = 0;

			new Triangle(sideA, sideB, sideC);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TriangleArea_OneOfSideMinus10_ArgumentException()
		{
			double sideA = -10;
			double sideB = 20;
			double sideC = 10;

			new Triangle(sideA, sideB, sideC);
		}

		[TestMethod]
		public void Area_When_TriangleSides3_4_5_Then_Area6()
		{
			double sideA = 3;
			double sideB = 4;
			double sideC = 5;
			double expected = 6;

			var triangle = new Triangle(sideA, sideB, sideC);
			double area = triangle.Area();

			Assert.AreEqual(expected, area);
		}

		[TestMethod]
		public void Area_When_TriangleSides1_1_20_Then_Area0()
		{
			double sideA = 1;
			double sideB = 1;
			double sideC = 20;
			double expected = 0;

			var triangle = new Triangle(sideA, sideB, sideC);
			double area = triangle.Area();

			Assert.AreEqual(expected, area);
		}

		[TestMethod]
		public void Area_When_TriangleSides2_4_5_Then_Area3dot8()
		{
			double sideA = 2;
			double sideB = 4;
			double sideC = 5;
			double expected = 3.799671038392666;

			var triangle = new Triangle(sideA, sideB, sideC);
			double area = triangle.Area();

			Assert.AreEqual(expected, area);
		}

		[TestMethod]
		public void IsRightTest_When_TriangleSides3_4_5_Then_IsRightTrue()
		{
			double sideA = 3;
			double sideB = 4;
			double sideC = 5;

			var triangle = new Triangle(sideA, sideB, sideC);

			Assert.IsTrue(triangle.IsRight());
		}

		[TestMethod]
		public void IsRightTest_When_TriangleSides4_5_sqrt41_Then_IsRightTrue()
		{
			double sideA = 4;
			double sideB = 5;
			double sideC = Math.Sqrt(41);

			var triangle = new Triangle(sideA, sideB, sideC);

			Assert.IsTrue(triangle.IsRight());
		}

		[TestMethod]
		public void IsRightTest_When_TriangleSides4_5_6_Then_IsRightFalse()
		{
			double sideA = 4;
			double sideB = 5;
			double sideC = 6;

			var triangle = new Triangle(sideA, sideB, sideC);

			Assert.IsFalse(triangle.IsRight());
		}
	}
}