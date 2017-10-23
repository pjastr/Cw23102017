using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod auto = new Samochod();
            auto.Model = "hghgh";
            auto.Cena = 34343;
            auto.Marka = "Skoda";

            string wejscie = Console.ReadLine();
            double.TryParse(wejscie, out auto.Cena);
        }
    }
}
