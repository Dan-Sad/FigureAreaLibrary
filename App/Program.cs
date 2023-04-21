using FigureAreaLibrary;

var random = new Random(DateTime.Now.Microsecond);

ICalculateArea figure = random.Next(2) == 0 ? new Triangle(11, 10, 15) : new Circle(11);
Console.WriteLine(figure.Area());