using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SOLID_Principle
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
        public class UserService
        {
            EmailService emailService;
            public UserService(EmailService aEmailService)
            {
                emailService = aEmailService;
            }
            public void Register(string email, string password)
            {
                if (!emailService.ValidateEmail(email))
                {
                    Console.WriteLine("Invalid Email.");
                }
                else
                {
                    Console.WriteLine("User Added/Register.");
                    emailService.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hi. How are you!" });
                }
            }
        }
        public class EmailService
        {
            public EmailService()
            {
                
            }
            public bool ValidateEmail(string email)
            {
                Console.WriteLine("Doing simple email validation.");
                Console.WriteLine("Validating @ present in email or not.");
                return email.Contains("@");
            }
            public void SendEmail(MailMessage message)
            {
                //_smtpClient.Send(message);
                Console.WriteLine("Email Sent to new user.");
            }
        }
    }
}
