using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemUsingFactoryPattern
{
    public class SmsNotificationCreator:NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new SMSNotification();
        }
    }
}
