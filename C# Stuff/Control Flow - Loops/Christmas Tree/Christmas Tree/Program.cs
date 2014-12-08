using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Welcome to the triangle program");
            Console.ReadKey();

            int triangleSize = 6;

            for(int i = 1; i <= triangleSize; i++)
            {
                for (int k = 1; k <= triangleSize - i; k++)
                    Console.Write(" ");
                for (int l = 1; l <= i; l++)
                    Console.Write(" *");
                    Console.WriteLine("");
            }
                for (int counter = 0; counter < 2; counter++)
                {
                     Console.WriteLine("      !");
                }

              Console.ReadKey();

            }
        }
     }
  

