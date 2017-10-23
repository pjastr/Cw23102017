using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Car
    {
        private double pojemonoscSilnika;
        private string marka;

        private Car()
        {
            this.pojemonoscSilnika = 5.2;
        }

        private Car(double pojemonoscSilnika, string marka)
        {
            this.pojemonoscSilnika = pojemonoscSilnika;
            this.marka = marka;
        }

        public static Car Create(string marka, double poj)
        {
            Car temp = new Car(poj, marka);
            return temp;
        }

        public readonly static int iloscKol;

        static Car()
        {
            iloscKol = 4;
        }

        ~Car()
        {
            Console.WriteLine("Zwalniam pamięć");
            Console.ReadKey();
        }

        public const int iloscDrzwi=5;

    }
}
