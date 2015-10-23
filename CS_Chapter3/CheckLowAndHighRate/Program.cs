using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Double payrate = 3.25;
            if (payrate < 5.65 || payrate > 49.99)
                Console.WriteLine("error");
          

        }
    }
}
