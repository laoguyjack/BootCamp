using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depreciation
{
    // Jack Savath
    // Depreciation.cs

    // Program 2 is a depreciation tool. It asks the user for the description of the equipment, the original
    // value of the equipment, and the annual depreciation amount of the equipment. The program will then
    // create a report that shows the depreciation value of the equipment for each year until the equipment
    // fully depreciated.

    class Depreciation
    {
        static void Welcome()
        {
            Console.WriteLine("\n\nWelcome to the Depreciation Tool. This tool will help create");
            Console.WriteLine("a depreciation report for the equipment that you would like");
            Console.WriteLine("to evaluate. Please enter the following questions to begin:");
        }

        static string Equipment()
        {
            string nameOfitem;
            Console.Write("\n\nWhat type of equipment will we be evaluating today? ");
            nameOfitem = Console.ReadLine();
            return nameOfitem;
        }

        static double ValueOfEquipment()
        {
            double priceOfitem;
            Console.Write("What was the original price of the equipment? ");
            priceOfitem = double.Parse(Console.ReadLine());
            return priceOfitem;
        }

        static double AnnualDepreciation()
        {
            double amtOfDepreciation;
            Console.Write("What is the annual depreciation of the equipment? ");
            amtOfDepreciation = double.Parse(Console.ReadLine());
            return amtOfDepreciation;
        }

        static void Goodbye()
        {
            Console.WriteLine("\n\nGoodBye!");
        }

        static void Main(string[] args)
        {
            string nameOfitem;
            double originalPrice;
            double depreciateValue;
            int totalYears;
            double endOfyearValue;
            double accumulatedDepreciation;
            const char YES = 'y';
            char ans = 'y';

            Welcome();

            while (ans == YES)
            {
            nameOfitem = Equipment();
            originalPrice = ValueOfEquipment();
            depreciateValue = AnnualDepreciation();

            Console.WriteLine("\n\nEquipment Descrption: {0}", nameOfitem);
            Console.WriteLine("Beginning Value: {0}", originalPrice);
            Console.WriteLine("Depreciation: {0}", depreciateValue);

            if (originalPrice % depreciateValue == 0)
                totalYears = (int)(originalPrice / depreciateValue); 
            else
                totalYears = (int)(originalPrice / depreciateValue) + 1;

            Console.WriteLine("\n\nYear     Depreciation     End-of-Year Value     Depreciation");
            for (int Year = 1; Year <= totalYears; Year++)
            {
                endOfyearValue = originalPrice - Year * depreciateValue;
                accumulatedDepreciation = depreciateValue * Year;
                 if (endOfyearValue < 0)
                    endOfyearValue = 0;
                Console.WriteLine("{0,3}  {1,13:c}  {2,20:c}  {3,16:c}", Year, depreciateValue, endOfyearValue, accumulatedDepreciation);
            }
            Console.Write("\n\nWould you like to evaulate another item? (y/n) ");
            ans = (char)Console.Read();
            Console.ReadLine();
            }
            Goodbye();
            Console.ReadLine();
        }
    }
}
