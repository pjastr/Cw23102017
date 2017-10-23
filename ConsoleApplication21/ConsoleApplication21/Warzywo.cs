using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Warzywo
    {
        public string nazwa;
        private double cena;
        public bool gmo;

        public int Promocja()
        {
            return 523;
        }

        public void Kupuje(int ile)
        {
            Console.WriteLine(ile);
        }

        public void UstawCene(double cena)
        {
            this.cena = cena;
        }
    }
}
