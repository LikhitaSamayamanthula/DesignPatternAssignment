using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemUsingFactoryPattern
{
    public class PushNotification:INotification
    {
        public void sendNotification(string message)
        {
            Console.WriteLine("Push Notification service :" + message);
        }
    }
}
