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
            Random dieroll = new Random();

            int die = dieroll.Next(1,7);
            Console.ReadKey();
            Console.WriteLine("You rolled a {0}", die);
        }
            
        }
    }

