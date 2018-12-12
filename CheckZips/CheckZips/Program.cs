using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int userZip;
            int[] zips = { 52804, 66666, 52806, 11111, 77777, 52809, 12345, 54321, 99999, 10101 };
            bool available = false;
            Write("You ordered a package. Please enter your Zip Code to check availability << ");
            userZip = Convert.ToInt32(ReadLine());

            for (int i = 0; i <= 9; i++)
            {
                if (userZip == zips[i])
                {
                    available = true;
                }

            }
            WriteLine("");
            if (available == true)
            {
                WriteLine("Zip Code available for delivery.");
            }
            else
            {
                WriteLine("Zip code unavailable for delivery.");
            }
            WriteLine("");
        }
    }
}
