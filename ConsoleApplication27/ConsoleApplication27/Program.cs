using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car auto = new Car();

            //Car auto2 = new Car(4.7, "Skoda");

            Car auto3 = Car.Create("Fiat", 4.2);
            //Car.iloscKol = 6;
            Car auto4 = Car.Create("Ford", 6.2);
            Console.WriteLine(Car.iloscDrzwi);
            //Car.iloscDrzwi = 8;
            Console.ReadKey();
            
            
        }
    }
}
