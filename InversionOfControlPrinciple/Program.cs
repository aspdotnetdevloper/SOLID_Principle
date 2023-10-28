using System;

namespace Inversion_Of_Control_Principle
{
    // Program.cs
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of EmailService (concrete implementation)
            IMessageService emailService = new EmailService();

            // Create an instance of NotificationService and inject the emailService
            NotificationService notificationService = new NotificationService(emailService);

            // Use the NotificationService to send a message (IoC)
            notificationService.SendNotification("Hello, IoC!", "user@example.com");

            Console.ReadKey();
        }
    }
}
