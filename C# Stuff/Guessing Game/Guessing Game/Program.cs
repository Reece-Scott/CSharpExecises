using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numGuess = random.Next(1, 50);
            Console.WriteLine("I am thinking of a number between 1 and 50, have a guess!");
            int userGuess = Int32.Parse(Console.ReadLine());

            if (userGuess > numGuess)
            {
                Console.WriteLine("No, the number is smaller than that");
                Console.ReadKey();
            }
            else if (userGuess < numGuess)
            {
                Console.WriteLine("No, the number is larger than that");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Correct! Well done");
                Console.ReadKey();
            }
        }
    }
}
