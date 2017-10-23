using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;

        private Car()
        {
            this.marka = "Ford";
        }

        private Car(double pojemnoscSilnika, string marka)
        {
            this.marka = marka;
            this.pojemnoscSilnika = pojemnoscSilnika;
        }

        public static Car Create(double pojemnosc, string marka)
        {
            Car temp = new Car(pojemnosc, marka);
            return temp;
        }

        public static int iloscKol;

        static Car()
        {
            iloscKol = 4;
        }

        public const int iloscDrzwi=4;

        ~Car()
        {
            Console.WriteLine("Zwalniam pamięć");
            Console.ReadKey();
        }
    }
}
