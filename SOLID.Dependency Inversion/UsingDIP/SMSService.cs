﻿using System;
namespace UsingDIP
{
    internal class SMSService : IMessageService
    {
        public string MobileNo { get; set; } 

        public void Send()
        {
            Console.WriteLine($"SMS is sent to {MobileNo}");
        }
    }
}
