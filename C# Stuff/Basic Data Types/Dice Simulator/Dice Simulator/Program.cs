using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int dieThrows = 1; dieThrows <= 50; dieThrows++)
            {
                Random diceNumber = new Random();
                int dieRoll = diceNumber.Next(1, 7);

                 Console.WriteLine("You rolled a {0}", dieRoll);
                 Console.WriteLine();
                 Console.WriteLine("Roll Again");
                 Console.ReadKey();
            }
               
        }
            
        }
    }

