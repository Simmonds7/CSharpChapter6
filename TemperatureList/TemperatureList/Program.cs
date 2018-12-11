using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperature = new int[7];
            int i;
            int j;
            int average;
            WriteLine("Input the temperatures for the next 7 days.");
            for (i = 0; i < 7; i++)
            {
                j = i + 1;
                Write("Enter temperature " + j + " <<");
                temperature[i] = Convert.ToInt32(ReadLine());

            }
            WriteLine("------------------------");
            average = (temperature[0] + temperature[1] + temperature[2] + temperature[3] + temperature[4] + temperature[5] + temperature[6]) / 7;
            j = 0;
            for (i = 0; i < 7; i++)
            {
                j = i + 1;
                WriteLine("Temperature for day " + j + " is " + temperature[i] + ", and is " + Math.Abs(temperature[i] - average) + " away from the average of " + average);
            }
        }
    }
}
