using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madlib
{
    class MatLib2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Jack's MadLib Game. This game will ask for a couple of questions");
            Console.WriteLine("and write a short story with the answers.");
            Console.WriteLine("Please answer the following questions to begin:");
            Console.WriteLine("");

            String nameOfPerson;
            int age;
            String nameOfCollege;
            String typeOfDegree;

            Console.Write("Enter your name: ");
            nameOfPerson = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter the College you attended: ");
            nameOfCollege = Console.ReadLine();
            Console.Write("Enter your major in College: ");
            typeOfDegree = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("{0} is {1} years old.", nameOfPerson, age);
            Console.WriteLine("{0} went to {1} majoring in {2}.", nameOfPerson, nameOfCollege, typeOfDegree);
            Console.WriteLine("All of {0}'s schooling and training has brought {0}", nameOfPerson);
            Console.WriteLine("to this very moment to play this MadLib Game.");
            Console.WriteLine("");
            Console.WriteLine("Thank you for playing this very basic game. Have a nice day!");
            Console.ReadLine();
        }
    }
}
