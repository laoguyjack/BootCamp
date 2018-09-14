using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // Jack Savath
    // Decisions.cs

    class Decisions
    {
        static void Main(string[] args)
        {
            int integerOne;
            int integerTwo;

            Console.WriteLine("This program will ask for two integers and determine if the");
            Console.WriteLine("1st integer is a multiple of the 2nd integer or not. Please");
            Console.WriteLine("make the 2nd integer greater than the 1st integer.");
            Console.WriteLine("");
            Console.Write("Please enter the 1st integer: ");
            integerOne = int.Parse(Console.ReadLine());
            Console.Write("Please enter the 2nd integer: ");
            integerTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (integerTwo % integerOne == 0)
            {
                Console.WriteLine("The 1st integer is a multiple of the 2nd integer.");
                Console.WriteLine("The factor is {0}", integerTwo / integerOne);
            }
            else
                Console.WriteLine("The 1st integer is not a multiple of the 2nd integer.");
            Console.WriteLine("");
            Console.WriteLine("Thank You for participating. Please hit enter to end.");
            Console.ReadLine();
        }
    }
}
