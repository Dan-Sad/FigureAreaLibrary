namespace FigureAreaLibrary
{
	public class Circle : ICalculateArea
	{
		private double _radius;

		public double Radius { get => _radius; set => _radius = RadiusValidate(value); }

		/// <summary> Circle by radius </summary>
		public Circle(double radius)
		{
			Radius = radius;
		}

		public double Area() => Math.PI * Radius * Radius;

		private double RadiusValidate(double value)
		{
			if (Validator.NotNanMoreZero(value))
				return value;
			else
				throw new ArgumentException($"Invalid radius value '{value}'");
		}
	}
}