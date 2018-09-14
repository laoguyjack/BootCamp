using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    // Jack Savath
    // Functions.cs

    class Functions
    {
        static void Welcome()
        {
            // this method prints a welcome message
            Console.WriteLine("\n\n");
            Console.WriteLine("Welcome to this program where it'll ask for a number and plug");
            Console.WriteLine("it into this equation: x = (x*2) - (x+25); and then prints it out.");
            Console.WriteLine();
        }

        static void Goodbye()
        {
            // this method prints a goodbye message
            Console.WriteLine("\n");
            Console.WriteLine("Goodbye!");
            Console.WriteLine();
        }

        static int Input()
        {
            // this method ask the user for a number between 5 and 25
            int NumbertoCalculate;                                      // user's number that will be calculated
            Console.Write("Please enter a number between 5 and 25: ");
            NumbertoCalculate = int.Parse(Console.ReadLine());
            return NumbertoCalculate;
        }

        static int Calculate(int CalculateNum)
        {
            // this method performs the following calcuation: (x*2)-(x+25)
            int result;                                                 // final result of number after calculation
            result = (CalculateNum * 2) - (CalculateNum + 25);
            return result;
        }

        static void Main(string[] args)
        {
            // declare variables
            int UsersNumber;                                            // user's number that will be calculated
            Welcome();
            UsersNumber = Input();
            Console.WriteLine("After the equation, the result is: {0}", Calculate(UsersNumber));
            Goodbye();
            Console.ReadLine();
        }
    }
}
