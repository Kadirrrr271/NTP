using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdf
{
    class Kedi: IBeslen,ISesCikar
    {
        public void SesCikar()
        {
            Console.WriteLine("kedi: miyav miyav");
        }
        public void Beslen()
        {
            Console.WriteLine("kedi: süt içti");
        }
    }
}
