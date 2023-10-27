
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Single_Responsibility_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Email:");
            string emailAddress = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            UserService userService = new UserService(new EmailService());
            userService.Register(emailAddress, password);
            Console.ReadLine();
        }
    }
}
