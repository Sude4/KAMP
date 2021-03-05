using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms yollandı");
        }
    }
}
