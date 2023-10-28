using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion_Of_Control_Principle
{
    // NotificationService.cs
    public class NotificationService
    {
        private IMessageService messageService;

        // Constructor-based dependency injection
        public NotificationService(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        public void SendNotification(string message, string recipient)
        {
            // Delegate the message sending to the injected messageService
            messageService.SendMessage(message, recipient);
        }
    }
}
