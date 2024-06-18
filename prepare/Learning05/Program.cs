using System;

class Program
{
  static void Main(string[] args)
  {
    List<Shape> shapes = new List<Shape>();
    Square square = new Square("red", 10);
    // Console.WriteLine($"Color: {square.GetColor()}");
    // Console.WriteLine($"Area: {square.GetArea()}");

    Rectangle rectangle = new Rectangle("blue", 10, 20);
    // Console.WriteLine($"Color: {rectangle.GetColor()}");
    // Console.WriteLine($"Area: {rectangle.GetArea()}");

    Circle circle = new Circle("green", 10);
    // Console.WriteLine($"Color: {circle.GetColor()}");
    // Console.WriteLine($"Area: {circle.GetArea()}");

    shapes.Add(square);
    shapes.Add(rectangle);
    shapes.Add(circle);

    foreach (Shape shape in shapes)
    {
      Console.WriteLine($"Color: {shape.GetColor()}");
      Console.WriteLine($"Area: {shape.GetArea()}");
    }
  }
}