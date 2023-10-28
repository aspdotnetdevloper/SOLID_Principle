using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion_Of_Control_Principle
{
    // IMessageService.cs
    public interface IMessageService
    {
        void SendMessage(string message, string recipient);
    }
}
