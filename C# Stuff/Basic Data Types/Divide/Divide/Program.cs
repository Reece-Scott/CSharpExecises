using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter the first number");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The two numbers divided equal: " + num1 / num2);
            Console.WriteLine();
            Console.WriteLine("To exit the program press any key...");
            Console.ReadKey();
        }
    }
}
