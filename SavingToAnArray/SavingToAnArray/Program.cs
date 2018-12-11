using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SavingToAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            int elementChoice;
            int[] arr = new int[10];
            int i;
            Write("\n\nRead and Print elements of an array;\n");
            Write("-----------------------------------------\n");
            Write("Input 10 elements in the array");
            for (i = 0; i < 10; i++)
            {
                Write("Enter a number - " + i + " << ");
                arr[i] = Convert.ToInt32(ReadLine());
            }
            WriteLine("Choose how you want your array displayed. E for the order entered, B for backwards, C to pick a number");
            choice = ReadLine();
            if (choice == "C" || choice == "c")
            {
                WriteLine("Pick a position in the Array.");
                elementChoice = Convert.ToInt32(ReadLine());
                WriteLine("Selected value is " + arr[elementChoice]);

            }
            else if (choice == "E" || choice == "e")
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    WriteLine("Numbers entered were " + arr[j]);
                }
            }
            else if (choice == "B" || choice == "b")
            {
                for (int j = 9; j >= 0; j--)
                {
                    WriteLine("Numbers entered backwards are " + arr[j]);
                    WriteLine("");
                }
            }
        }
    }
}
