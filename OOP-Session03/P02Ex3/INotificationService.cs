using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session03.P02Ex3
{
    internal interface INotificationService
    {
        void SendNotification(string Recipient, string Message);
    }
}
