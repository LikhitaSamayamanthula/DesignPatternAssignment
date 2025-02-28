using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemUsingFactoryPattern
{
    public interface INotification
    {
        public void sendNotification(string message);
    }
}
