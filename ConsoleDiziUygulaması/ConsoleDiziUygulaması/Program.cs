using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDiziUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("satır sayısını gir>>>");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun sayısını gir >>>");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("___________");
            Random rnd = new Random();

            int[,] dizi2 = new int[a, b];
            for(int i=0; i<a; i++)
            {
                for(int j=0;j<b;j++)
                {
                    dizi2[i, j] = rnd.Next(0, 50);
                    Console.Write(dizi2[i, j] + "-");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
