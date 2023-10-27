using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
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
