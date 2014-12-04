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
            int randomNumber = random.Next(1, 5);
            Console.WriteLine("I am thinking of a number between 1 and 5, have a guess!");
            int playerGuess = Int32.Parse(Console.ReadLine());

            if (playerGuess == randomNumber)
            {
                Console.WriteLine("Correct! Well Done");
                Console.ReadKey();
            }-
        }
    }
}
