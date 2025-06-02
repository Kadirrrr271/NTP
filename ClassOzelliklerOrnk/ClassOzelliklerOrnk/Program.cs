using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOzelliklerOrnk
{
    class Sinifim
    {
        public void Selamla(string ad = "Emre")
        {
            Console.WriteLine("merhaba:" + ad);
            Console.ReadKey();
        }
    }
    class Program
    { 

        static void Main(string[] args)
        {
            Sinifim s = new Sinifim();
            s.Selamla();
            s.Selamla("defne");
                
         }
    }
}
