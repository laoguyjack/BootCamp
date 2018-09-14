using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    // Jack Savath
    // PrettyFors.cs

    class PrettyFors
    {
        static void Main(string[] args)
        {
            int UsersNumber;
            Console.Write("Please enter an interger: ");
            UsersNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\n1. X copies of X on one line. \n");                       // Pattern 1
            for (int i = 1; i <= UsersNumber; i++)
                Console.Write(UsersNumber);

            Console.WriteLine("\n\n\n2. X lines with a single 1 on each line. \n");                 // Pattern 2
            for (int i = 1; i <= UsersNumber; i++)
                Console.WriteLine("1");

            Console.WriteLine("\n\n3. Multiplication number to X. \n");                           // Pattern 3
            Console.Write("    ");
            for (int i = 1; i <= UsersNumber; i++)
                Console.Write("{0,4}", i);
                Console.WriteLine("");
                for (int r = 1; r <= UsersNumber; r++)
                {
                    Console.Write("{0,4}", r);
                    for (int c = 1; c <= UsersNumber; c++)
                    {
                        Console.Write("{0,4}",r*c);
                    }
                    Console.WriteLine();
                }
            
            Console.WriteLine("\n\n4. X lines with 1 ones on the first line, 2 twos");          // Pattern 4
            Console.WriteLine("   on the second, etc. to X Xes on the last line.");
            for (int i = 1; i <= UsersNumber; i++ )
            {
                Console.WriteLine("");
                for (int j = 1; j <= i; j++)
                    Console.Write("{0,3} ",i);
            }


            Console.WriteLine("\n\n5. The outline of a half-diamond, with X at the widest point."); // Pattern 5
            for (int i = 1; i < UsersNumber; i++ )
            {
                Console.WriteLine("");
                for (int j = 1; j <= i; j++)
                {
                    if (i != j)
                        Console.Write(" ");
                    else
                        Console.Write(i);
                }
            }

            for (int i = UsersNumber; i >=1; i--)
            {
                Console.WriteLine("");
                for (int j = 1; j <= i; j++)
                {
                    if (i != j)
                        Console.Write(" ");
                    else
                        Console.Write(i);
                }
            }
            Console.WriteLine();
                Console.ReadLine();
        }
    }
}
