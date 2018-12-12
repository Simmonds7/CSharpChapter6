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
            int j;
            int[] scores = new int[4];

            for (i = 0; i <= 3; i++)
            {
                j = i + 1;
                Write("Enter test score " + j + " <<");
                input = Convert.ToInt32(ReadLine());
                if (input >= MIN && input <= MAX)
                {
                    scores[i] = input;
                }
                else
                {
                    WriteLine("Invalid Score.");
                    i--;
                }
            }
            if (scores[3] >= scores[2] && scores[2] >= scores[1] && scores[1] >= scores[0])
            {
                WriteLine("Congratulations. Improvement across the board.");
                for (i = 0; i <= 3; i++)
                {
                    j = i + 1;
                    WriteLine("Score " + j + " was " + scores[i] + ".");
                }
            }
            else if (scores[3] <= scores[2] && scores[2] <= scores[1] && scores[1] <= scores[0])
            {
                WriteLine("You have dissapointed me. More and more failure. You're terrible.");
                for (i = 0; i <= 3; i++)
                {
                    j = i + 1;
                    WriteLine("Score " + j + " was " + scores[i] + ".");
                }
            }
            else
            {
                WriteLine("Did you even pay attention?! Or did you cheat off of a different person every time? How do you even do that?");
                for (i = 0; i <= 3; i++)
                {
                    j = i + 1;
                    WriteLine("Score " + j + " was " + scores[i] + ".");
                }
            }

        }
    }
}
