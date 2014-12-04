using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter the first number to be multiplied");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.Write("The two numbers multiplied equal: " + num1 * num2);
            Console.ReadKey();
        }
    }
}
