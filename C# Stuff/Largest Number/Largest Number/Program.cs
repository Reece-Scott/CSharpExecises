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
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter the second number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine();
                Console.WriteLine("{0} is larger than {1}", num1, num2);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("{0} is larger than {1}", num2, num1);
            }
            Console.ReadKey();
        }
    }
}
