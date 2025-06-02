using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoglamaOrnegi
{
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Sms gönderildi");
        }
    }
}
