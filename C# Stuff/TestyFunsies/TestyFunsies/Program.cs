using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyFunsies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the test program V.0.1");
            Console.WriteLine();
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age ");
            string age = Console.ReadLine();
            Console.WriteLine("And finally, please enter your birth year");
            string birthYear = Console.ReadLine();
            string welcome = string.Format("Hello {0}, welcome to the program; I see you are {1} years old and born in {2}", name, age, birthYear);
            Console.WriteLine();
            Console.WriteLine(welcome);
            Console.ReadKey();

        }
    }
}
