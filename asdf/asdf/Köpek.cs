using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdf
{
    class Köpek:IBeslen,ISesCikar
    {
        public void SesCikar()
        {
            Console.WriteLine("köpek: hav hav");
        }
        public void Beslen()
        {
            Console.WriteLine("köpek: et yedi");
        }
    }
}
