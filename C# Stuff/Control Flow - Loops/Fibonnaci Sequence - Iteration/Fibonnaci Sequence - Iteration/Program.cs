using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci_Sequence___Iteration
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This program counts up to 45 in a fibonacci sequence");


            for (int i = 0; i <= 45; i++)
            {
                Console.WriteLine(FibonacciCalculator(i));
            }
            Console.ReadKey();
        }

        public static int FibonacciCalculator(int n)    
        {
            int finNumber1 = 0;
            int finNumber2 = 1;
            int sumNumber = 1;

            for (int i = 0; i < n; i++)
            {
                sumNumber = finNumber1;
                finNumber1 = finNumber2;
                finNumber2 = sumNumber + finNumber2;
            }
            return finNumber1;
        }
    }
}
