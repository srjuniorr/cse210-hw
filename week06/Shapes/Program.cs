using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Red", 3));
        shapes.Add(new Rectangle("Blue", 4, 2));
        shapes.Add(new Circle("Green", 5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea():F2}.");
        }
    }
}
