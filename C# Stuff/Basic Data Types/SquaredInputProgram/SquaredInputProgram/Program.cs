using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaredInputProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter the number to be squared");
            int num = Int32.Parse(Console.ReadLine());
            Console.Write("Squared: " + num * num);
            Console.ReadKey();
        }
    }
}
