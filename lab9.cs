using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab9
{
    // Jack Savath
    // lab9.cs

    class lab9
    {

        static int LinearSearch(int target, int[] list, int numElements)
        {
            // This method searches the array for the number that the user searches for.
            // It'll then tell the user what index of the array the number is stored in.
            // Otherwise, the method will return a value of -1, signifying that the number
            // is not in the array

            int currentIndex = 0;

            while (currentIndex < numElements && list[currentIndex] != target)
            {
                currentIndex++;
            }

            if (currentIndex < numElements)
            {
                return currentIndex;
            }
            else
            {
                return -1;
            }
        }

        const string PATH = "input file.txt";
        static void Main(string[] args)
        {

            StreamReader f;
            int index = 0;                      // starts the array's index at 0
            String line;                        // the string variable used to read over the value from the file
            const char YES = 'y';               // used to keep the program going for as long as the user wishes
            char ans = 'y';                     // declared to get the while loop going
            int numberTofind;                   // user's input to try to find in the array
            int sizeOfarray = 50;               
            int[] array = new int[sizeOfarray];

            f = new StreamReader(PATH);
            while((line = f.ReadLine()) != null)
            {
            if (line.Length > 0)
              {
                 array[index] = int.Parse(line);
                 index++;
              }
            }

            while (ans == YES)
            {
                Console.Write("\n\nEnter the number you wish to find in the array: ");
                numberTofind = int.Parse(Console.ReadLine());
                int result = LinearSearch(numberTofind, array, index);
                if (result >= 0)
                    Console.WriteLine("The number {0} is located in index {1} of the array.", numberTofind, result);
                else
                    Console.WriteLine("Sorry, the array does not contain the number {0}", numberTofind);
                Console.Write("Would you like to find another number? (y/n) ");
                ans = (char)Console.Read();
                Console.ReadLine();
            }
            Console.Write("\n\nGoodBye!");
            Console.ReadKey();
        }
    }
}
