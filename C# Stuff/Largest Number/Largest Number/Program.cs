using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcom to the largest number program");
            Console.WriteLine();
            Console.Write("Please enter the first number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter the second number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine();
                Console.WriteLine("{0} is the largest number", firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("{0} is the largest number", secondNumber, firstNumber);
            }
            Console.ReadKey();
        }
    }
}
