using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourlypayrate = 3.75;
            if (hourlypayrate < 5.65)
                Console.WriteLine("error");
        }
    }
}
