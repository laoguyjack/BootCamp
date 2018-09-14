using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab10
{
    class lab10
    {

        static string[] SelectionSort(string[] list, int numElements)
        {
            int index;
            string temp;
            string[] word = new string[numElements];

            for (int i = 0; i < numElements; i++)
            {
                // linear search
                index = i;
                for (int j = index + 1; j < numElements; j++)
                {
                    if (list[j].CompareTo(list[index]) < 0)
                    {
                        index = j;
                    }
                }
                temp = list[index];
                list[index] = list[i];
                list[i] = temp;
            }
            word = list;
            return word;
        }

        static void Output(string[] word)
        {
            int sizeArray = 60;
            for (int i = 0; i < sizeArray; i++)
                Console.WriteLine(word[i]);
        }

        const string PATH = "lab10input.txt";

        static void Main(string[] args)
        {
            StreamReader f;
            string value;
            String line;
            int sizeArray = 60;
            string[] words = new string[sizeArray];
            int counter = 0;
            string[] word = new string[sizeArray];
            if (!File.Exists(PATH))
            {
                Console.Write("File problem, exiting program....");
            }
            else
            {
                f = new StreamReader(PATH);
                while ((line = f.ReadLine()) != null)
                {
                    String[] strings = line.Split();
                    if (strings.Length > 0)
                    {
                        value = strings[0];
                        words[counter] = value;
                        counter++;
                    }
                }
                f.Close();
                Output(words);
                word = SelectionSort(words, counter);
                Output(word);
            }
            Console.ReadKey();
        }
    }
}
