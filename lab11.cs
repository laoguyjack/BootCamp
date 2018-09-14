using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab11
{
    // Jack Savath
    // Lab 11.cs

    class lab11
    {
        static int[] SelectionSort(int[] list, int numElements)
        {
            int index;
            int temp;

            for (int i = 0; i < numElements - 1; i++)
            {
                index = i;

                for (int j = i + 1; j < numElements; j++)
                {
                    if (list[j].CompareTo(list[index]) < 0)  // see Ch. 6 for string items
                        index = j;
                }

                if (index != i)
                {
                    temp = list[index];
                    list[index] = list[i];
                    list[i] = temp;
                }
            }
            return list;
        }

        static int BinarySearch(int[] list, int numElements, int target)
        {
            int first = 0;
            int last = numElements - 1;
            int middle = (first + last) / 2;

            while (first <= last && list[middle] != target)
            {
                if (list[middle] > target)
                {
                    last = middle - 1;
                }
                else
                {
                    first = middle + 1;
                }
                middle = (first + last) / 2;
            }
            while (middle > 0 && list[middle] == list[middle - 1])
            {
                --middle;
            }
            return middle;
        }


        const string PATH = "lab11input.txt";
        static void Main(string[] args)
        {

            StreamReader f;
            int value;
            int ArraySize = 30;
            int[] number = new int[ArraySize];
            int counter = 0;
            int[] sorted = new int[ArraySize];
            int find;
            int found;
            const char YES = 'y';
            char ans = 'y';

            String line;

            if (!File.Exists(PATH))
            {
                Console.Write("File problem, exiting program....");
            }

            else
            {
                f = new StreamReader(PATH);
                while ((line = f.ReadLine()) != null)
                {
                    if (line.Length > 0)
                    {
                        value = int.Parse(line);
                        number[counter] = value;
                        counter++;
                    }
                }
                f.Close();
            }
            sorted = SelectionSort(number, counter);
            while (ans == YES)
            {
                Console.Write("\n\nWhat number would you like to search for in the array? ");
                find = int.Parse(Console.ReadLine());
                found = BinarySearch(number, counter, find);
                Console.WriteLine("The first occurrence of {0} can be found at index {1}.", find, found);
                Console.Write("\n\nWould you like to find another number? (y/n) ");
                ans = (char)Console.Read();
                Console.ReadLine();
            }
        }
    }
}
