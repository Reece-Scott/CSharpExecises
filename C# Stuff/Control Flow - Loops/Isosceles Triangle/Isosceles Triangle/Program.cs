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
                Console.WriteLine("How large is the triangle?");
                int triangleSize = int.Parse(Console.ReadLine());

                
                for (int i = 0; i < triangleSize; i++)
                {
                    for (int k = 0; k < i; k++)
                        Console.Write("*");
                    Console.WriteLine();
                }

                Console.ReadKey();
            }
         }
      }

