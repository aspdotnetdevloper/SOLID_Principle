
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Single_Responsibility_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of different shapes
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);
            Shape triangle = new Triangle(3, 4);

            // Calculate and display the areas of these shapes
            Console.WriteLine("Circle Area: " + circle.Area());
            Console.WriteLine("Rectangle Area: " + rectangle.Area());
            Console.WriteLine("Triangle Area: " + triangle.Area());

            Console.ReadLine();
        }
    }
}
