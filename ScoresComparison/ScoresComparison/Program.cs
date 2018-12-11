using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ScoresComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            const int MAX = 100;
            const int MIN = 0;
            int i = 0;
            int j = i + 1;
            int[] scores = new int[4];

            for (i = 0; i <= 3; i++)
            {
                Write("Enter test score " + j + " <<");
                input = Convert.ToInt32(ReadLine());
                if (input >= MIN && input <= MAX)
                {
                    input = scores[i];
                }
                else
                {
                    WriteLine("Unacceptable Score.");
                    i--;
                }
            }
        }
    }
}
