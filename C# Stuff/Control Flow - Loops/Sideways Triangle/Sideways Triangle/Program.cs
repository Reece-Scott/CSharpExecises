using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sideways_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the sideways triangle program");
            Console.WriteLine();
            Console.WriteLine("How large would you like the triangle?");
            int triangleSize = int.Parse(Console.ReadLine());

            int i;
            int k;
            int j;
            int foo = 0;

            for (i = 0; i <= triangleSize; i++)
            {
                for (k = 0; k < i; k++)
                    Console.Write("*");
                    Console.WriteLine();
            }
            for (i = triangleSize; i >= 0; i-- )
            {

                for (j = 0; j < i; j++)
                    Console.Write("*");
                    Console.WriteLine();
            }
                Console.ReadKey();
        }
    }
}