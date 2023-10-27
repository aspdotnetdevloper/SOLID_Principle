using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class UserService
    {
        EmailService emailService;
        public UserService(EmailService _emailService)
        {
            emailService = _emailService;
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
}
