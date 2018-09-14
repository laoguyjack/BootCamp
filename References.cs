using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    // Jack Savath
    // References.cs

    class References
    {
        static void Input(out double i, out double j)
        {
            // this method asks the user for 2 numbers
            Console.Write("\n\nEnter the first number: ");
            i = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            j = double.Parse(Console.ReadLine());
        }

        static void SwapVal(ref double i, ref double j)
        {
            // this method swaps the two numbers
            double x = i;
            double y = j;
            i = y;
            j = x;
        }

        static void Output(ref double i, ref double j)
        {
            // this method outputs the two numbers
            Console.WriteLine("{0} {1}", i, j);
        }

        static void Main(string[] args)
        {
            double numOne;                          // this is the first number
            double numTwo;                          // this is the second number
            Input(out numOne, out numTwo);
            Output(ref numOne, ref numTwo);
            SwapVal(ref numOne, ref numTwo);
            Output(ref numOne, ref numTwo);
            Console.ReadLine();
        }
    }
}
