using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            String typeOfWood;
            Console.Write("Please Choose P for Pine, O for Oak, or M for Mahogany: ");
            typeOfWood = Console.ReadLine();
            if (typeOfWood == "O")
            {
                Console.WriteLine("The cost is $225");
            }
            if (typeOfWood == "P")
                Console.WriteLine("The cost is $100");
            if (typeOfWood == "M")
                Console.WriteLine("The cost is $310");
            if (typeOfWood =="P"||typeOfWood == "O" ||typeOfWood== "M")
                Console.WriteLine("Thank You!!");
            else
                Console.WriteLine("0");

        }
    }
}
