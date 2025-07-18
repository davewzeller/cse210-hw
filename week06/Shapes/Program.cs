using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        List<Shape> shape = new List<Shape>();
        //Console.WriteLine("Hello World! This is the Shapes Project.");

        Circle s1 = new Circle("Blue", 10);
        shape.Add(s1);

        Square s2 = new Square("Purple", 3);
        shape.Add(s2);

        Rectangle s3 = new Rectangle("Black", 4, 5);
        shape.Add(s3);

        foreach (Shape s in shape)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The color is {color}, and the shape has an area of {area}");
        }
    }
}