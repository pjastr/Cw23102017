using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Matematyka
    {
        private static double pi = 3.14;

        public static double PoleKola(int r)
        {
            return pi * r * r;
        }

        public static double ObowdKola(int r)
        {
            return pi * r * 2;
        }
    }
}
