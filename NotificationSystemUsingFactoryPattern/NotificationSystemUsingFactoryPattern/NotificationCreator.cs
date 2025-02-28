using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemUsingFactoryPattern
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();

        public void Notify(string message)
        {
            INotification notification = CreateNotification();
            notification.sendNotification(message);
        }
    }
}
