using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdf
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.SesCikar();
            kedi.Beslen();
            Köpek köpek = new Köpek();
            köpek.SesCikar();
            köpek.Beslen();
            Console.WriteLine("========================");
            ISesCikar hayvan1 = kedi;
            ISesCikar hayvan2 = köpek;
            hayvan1.SesCikar();
            hayvan2.SesCikar();
            Console.WriteLine("==========================");
            IBeslen beslen1 = kedi;
            IBeslen beslen2 = köpek;
            beslen1.Beslen();
            beslen2.Beslen();
            Console.ReadKey();   
        }
    }
}
