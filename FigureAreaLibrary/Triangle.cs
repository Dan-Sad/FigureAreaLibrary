using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary
{
	public class Triangle : ICalculateArea
	{
		private double _sideA, _sideB, _sideC;

		public double SideA { get => _sideA; set => _sideA = SideValidate(value); }
        public double SideB { get => _sideB; set => _sideB = SideValidate(value); }
		public double SideC { get => _sideC; set => _sideC = SideValidate(value); }

		/// <summary> Triangle by lengths of three sides </summary>
		public Triangle(double sideA, double sideB, double sideC) 
		{ 
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}

		public double Area()
		{
			double semiP = (_sideA + _sideB + _sideC) / 2; // Semiperimeter
			double radicalExpression = semiP * (semiP - _sideA) * (semiP - _sideB) * (semiP - _sideC);
			if (radicalExpression < 0) return 0;

			double area = Math.Sqrt(radicalExpression);
			return area;
		}

		/// <returns> <c>true</c> if the triangle is right; otherwise <c>false</c></returns>
		public bool IsRight()
		{
			double powA = _sideA * _sideA;
			double powB = _sideB * _sideB;
			double powC = _sideC * _sideC;

			if (powA == powB + powC || powB == powA + powC || powC == powA + powB)
				return true;
			else
				return false;
		}

		private double SideValidate(double value)
		{
			if (Validator.NotNanMoreZero(value))
				return value;
			else
				throw new ArgumentException($"Invalid value length of side '{value}'");
		}
	}
}
