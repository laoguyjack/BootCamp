using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8
{
    // Jack Savath
    // lab8.cs

    class lab8
    {
        const string PATH = "lab8input.txt";
        static void Main(string[] args)
        {
            int sizeOfarray = 30;
            int[] evenNum = new int[sizeOfarray];
            int[] oddNum = new int[sizeOfarray];
            int[] negNum = new int[sizeOfarray];
            int i = 0;                                      // index increment counter for even array
            int j = 0;                                      // index increment counter for odd array
            int k = 0;                                      // index increment counter for negative array
            int counter = 0;                               // counter to print array's index and its value
            StreamReader f;
            int x;
            String line;                                    // name of string being read from text file

                f = new StreamReader(PATH);
                while ((line = f.ReadLine()) != null)
                {
                    if (line.Length > 0)
                    {
                        x = int.Parse(line);
                        if (x > 0 && x % 2 == 0)
                        {
                            evenNum[i] = x;
                            i++;
                        }
                        else if (x > 0)
                        {
                            oddNum[j] = x;
                            j++;
                        }
                        else if (x < 0)
                        {
                            negNum[k] = x;
                            k++;
                        }
                    }
                }

            Console.WriteLine("\n\nEven Numbers");
            Console.WriteLine("Index:     Value:");
            for (counter = 0; counter < i; counter++)
                Console.WriteLine("  {0} {1,10}",counter, evenNum[counter]);
           
            Console.WriteLine("\n\nOdd Numbers");
            Console.WriteLine("Index:     Value:");
            for (counter = 0; counter < j; counter++)
                Console.WriteLine("  {0} {1,10}",counter, oddNum[counter]);
            
            Console.WriteLine("\n\nNegative Numbers");
            Console.WriteLine("Index:     Value:");
            for (counter = 0; counter < k; counter++)
                Console.WriteLine("  {0} {1,10}",counter, negNum[counter]);
                Console.ReadKey();
        }
    }
}
