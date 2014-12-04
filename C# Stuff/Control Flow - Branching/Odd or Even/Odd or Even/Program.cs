using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the Odd Or Even Program");
            Console.WriteLine();
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine();
                Console.Write("{0} is a even number", number);
            }
            else
            {
                Console.Write("{0} is a odd number", number);
            }
            Console.ReadKey();

        }
    }
}
