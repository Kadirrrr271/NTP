using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoglamaOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CustomerManager customerManager = new CustomerManager();
           customerManager.Logger = new DatabaseLogger();
           customerManager.Add();
           customerManager.Logger = new FileLogger();
           customerManager.Add();
           Console.ReadLine();
        }
    }
}
