using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            String gradePoint;
            Console.Write("Please enter your grade point average");
            gradePoint= Console.ReadLine();
             String testScore;
            Console.Write("Please enter your test score");
            testScore= Console.ReadLine();

            if (gradePoint => 3.0)
            {
                if (testScore >= 60)
                    Console.WriteLine("Accept");

                else
            {
                    if (testScore >= 80)
                        Console.WriteLine("Accept");
                    else Console.WriteLine("Reject");
            }       


        }
    }
}
