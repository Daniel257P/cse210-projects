using System;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes.Shape> shapes = new List<Shapes.Shape>();
        
        Square square = new Square("Blue", 4);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Red", 5, 3);
        shapes.Add(rectangle);  

        Circle circle = new Circle("Green", 2);
        shapes.Add(circle); 

        foreach (Shapes.Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}, Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}