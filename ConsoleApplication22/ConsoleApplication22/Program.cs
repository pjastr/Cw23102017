using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car auto = new Car();

            //Car auto2 = new Car(5.4, "Skoda");

            Car auto3 = Car.Create(6.2, "Fiat");
            Car.iloscKol = 6;
            Car auto4 = Car.Create(5.1, "Honda");
            

            

            
        }
    }
}
