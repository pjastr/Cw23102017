﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod auto = new Samochod();
            auto.Model = "sdsd";
            auto.Cena = 56633;
            auto.Marka = "Skoda";

            string wejscie = Console.ReadLine();
            //double.TryParse(wejscie, out auto.Cena);
            auto.Cena = Convert.ToDouble(wejscie);
        }
    }
}
