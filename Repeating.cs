using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    // Jack Savath
    // Repeating.cs
    class Repeating
    {
        static void Main(string[] args)
        {
            int integerOne;
            int integerTwo;
            const char YES = 'y';
            char decide = 'y';

            Console.WriteLine("This program will ask for two integers and determine if the");
            Console.WriteLine("1st integer is a multiple of the 2nd integer or not. Please");
            Console.WriteLine("make the 2nd integer greater than the 1st integer.");

            while (char.ToLower(decide) == YES)
            {
                integerOne = 0;
                integerTwo = 0;
            Console.WriteLine("");
            while (integerOne == 0)
              {
                Console.Write("Please enter a number greater than 0 for the 1st integer: ");
                integerOne = int.Parse(Console.ReadLine());
              }

            Console.WriteLine("");
            while (integerTwo == 0)
              {
                Console.Write("Please enter the a number greater than 0 for the 2nd integer: ");
                integerTwo = int.Parse(Console.ReadLine());
              }
            Console.WriteLine("");
 
                if (integerTwo % integerOne == 0)
                {
                Console.WriteLine("The 1st integer is a multiple of the 2nd integer.");
                Console.WriteLine("The factor is {0}", integerTwo / integerOne);
                }
                else
                Console.WriteLine("The 1st integer is not a multiple of the 2nd integer.");
                Console.WriteLine("");
                Console.Write("Thank You for participating. Would you like to try again (y/n)? ");
                decide = (char)Console.Read();
                Console.ReadLine();
            }
        }
    }
}
