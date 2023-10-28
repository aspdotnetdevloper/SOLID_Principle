using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion_Of_Control_Principle
{
    public class EmailService : IMessageService
    {
        public void SendMessage(string message, string recipient)
        {
            // Code to send an email
            Console.WriteLine($"Email sent to {recipient}: {message}");
        }
    }
}
