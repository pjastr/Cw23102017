using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {

            Warzywo jablko = new Warzywo();
            jablko.nazwa = "Jabłko";
            jablko.gmo = false;
            jablko.UstawCene(3.23);

            jablko.Promocja();
            jablko.Kupuje(6);
        }
    }
}
