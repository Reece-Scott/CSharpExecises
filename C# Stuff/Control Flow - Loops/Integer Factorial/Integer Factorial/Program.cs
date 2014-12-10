using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the factorial calculator");
            Console.WriteLine();
            Console.WriteLine("Please enter a number");
            int inputNumber = int.Parse(Console.ReadLine());
            int factorialNumber = inputNumber;

            for (i = inputNumber - 1; i >= 1; i--)
            {
                factorialNumber = factorialNumber * i;
            }
            Console.WriteLine("{0}", factorialNumber);
            Console.ReadKey();
        }

        public static int i { get; set; }
    }
}
