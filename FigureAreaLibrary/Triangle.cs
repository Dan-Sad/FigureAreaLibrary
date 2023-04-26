namespace FigureAreaLibrary
{
	public class Triangle : ICalculateArea
	{
		private double _sideA, _sideB, _sideC;

		public double SideA 
		{ 
			get => _sideA; 
			set 
			{ 
				_sideA = SideValidate(value); 
				CheckTriangleExist(); 
			}
		}
        public double SideB 
		{ 
			get => _sideB; 
			set 
			{ 
				_sideB = SideValidate(value);
				CheckTriangleExist();
			}
		}
		public double SideC 
		{ 
			get => _sideC; 
			set 
			{
				_sideC = SideValidate(value);
				CheckTriangleExist();
			}
		}

		/// <summary> Triangle by lengths of three sides </summary>
		public Triangle(double sideA, double sideB, double sideC) 
		{
			_sideA = SideValidate(sideA);
			_sideB = SideValidate(sideB);
			_sideC = SideValidate(sideC);
			CheckTriangleExist();
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
		public bool IsRight(int epsilon = 5)
		{
			double powA = Math.Round(_sideA * _sideA, epsilon);
			double powB = Math.Round(_sideB * _sideB, epsilon);
			double powC = Math.Round(_sideC * _sideC, epsilon);

			if (powA == powB + powC || powB == powA + powC || powC == powA + powB)
				return true;
			else
				return false;
		}

		private double SideValidate(double value)
		{
			if (value <= 0 || double.IsNaN(value))
				throw new ArgumentException($"Invalid value length of side '{value}'");
			else
				return value;
		}

		private bool CheckTriangleExist()
		{
			if (_sideA + _sideB > _sideC && _sideA + _sideC > _sideB && _sideB + _sideC > _sideA)
				return true;
			else
				throw new Exception($"Triangle with sides: {_sideA}, {_sideB}, {_sideC} doesn't exist");
		}
	}
}
