using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isosceles_Triangle
{
    class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the sideways triangle program");
                Console.WriteLine();
                Console.WriteLine("Press enter to draw a triangle");
                Console.ReadKey();

                int i;
                int k;
                for (i = 0; i < 8; i++)
                {
                    for (k = 0; k < i; k++)
                        Console.Write("*");
                    Console.WriteLine();
                }

                Console.ReadKey();
            }
         }
      }

