using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkranİslemOrnk
{
    class EkranIslem
    {
        public void EkranaYaz(params int[] sayilar)
        {
            if (sayilar.Length == 0)
            {
                Console.WriteLine("Parametre olmadığı için metottan çıkılıyor");
                return;
            }
            Console.WriteLine("parametreden gelen değerler:");
            foreach ( var s in sayilar)
            {
                Console.WriteLine(s);
            }
        }
    }
    class program
    {     
        static void Main(string[] args)
        {
            EkranIslem ei = new EkranIslem();
            ei.EkranaYaz(3, 4, 5);
            Console.WriteLine("==================");
            ei.EkranaYaz();
            Console.ReadKey();
        }
    }
}
