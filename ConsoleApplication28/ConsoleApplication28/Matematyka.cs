using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Matematyka
    {
        private static double pi = 3.14;

        public static double PromienKola(int r)
        {
            return pi * r * r;
        }

        public static double ObwodKola(int r)
        {
            return pi * r * 2;
        }
    }
}
