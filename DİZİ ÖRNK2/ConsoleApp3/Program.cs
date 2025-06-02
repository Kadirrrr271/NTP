using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[3];
            for (int  i= 0; i< 3 ; i++)
            {
                Console.Write("sehir: ");
                sehirler[i] = Console.ReadLine();
            }
            Console.WriteLine("_____Şehirler_____");

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine(sehirler[i]);
            }
            Console.Read();
        }
    }
}
