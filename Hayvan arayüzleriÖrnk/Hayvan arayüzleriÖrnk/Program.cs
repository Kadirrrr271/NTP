using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvan_arayüzleriÖrnk
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new kedi();
            kedi.SesCikar();
            kedi.Beslen();
            Kopek köpek = new Kopek();
            köpek.SesCikar();
            köpek.Beslen();
            Console.WriteLine("========================");
            IHayvan hayvan1 = kedi;
            IHayvan hayvan2 = köpek;
            hayvan1.SesCikar();
            hayvan2.SesCikar();
            Console.WriteLine("==========================");
            IBeslen beslen1 = kedi;
            IBeslen beslen2 = köpek;
            beslen1.Beslen();
            beslen2.Beslen();
        }
    }
}
