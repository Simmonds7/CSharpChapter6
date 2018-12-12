using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int days;
            int[] nightPrices = { 0, 200, 200, 180, 180, 160, 160, 160, 145 };
            Write("Welcome to the C# bed and breakfast. How many nights will you be staying? << ");
            days = Convert.ToInt32(ReadLine());

            if (days >= 8)
            {
                WriteLine("You have chosen to stay for {0} night(s) at $145 per night. Your total is ${1}", days, (days * 145));
            }
            else
            {
                WriteLine("You have chosen to stay for {0} night(s) at ${1} per night. Your total is ${2}", days, nightPrices[days], (days * nightPrices[days])); 
            }

        }
    }
}
