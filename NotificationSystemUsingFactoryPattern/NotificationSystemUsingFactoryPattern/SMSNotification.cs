﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemUsingFactoryPattern
{
   public class SMSNotification:INotification
    {
        public void sendNotification(string message)
        {
            Console.WriteLine("SMS notification service :"+ message);
        }

    }
}
