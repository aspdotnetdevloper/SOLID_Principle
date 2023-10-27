using System;

namespace Liskov_Substitution_Principle
{
    class Program
    {
        static void CalculateAndDisplayArea(Shape shape)
        {
            double area = shape.Area();
            Console.WriteLine($"Area: {area}");
        }

        static void Main()
        {
            Shape shape1 = new Circle(5);
            Shape shape2 = new Rectangle(4, 6);

            CalculateAndDisplayArea(shape1); // Calculate and display the area of a circle
            CalculateAndDisplayArea(shape2); // Calculate and display the area of a rectangle

            Console.ReadLine();
        }
    }
}
