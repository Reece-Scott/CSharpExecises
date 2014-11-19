using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Format_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("What is your Date Of Birth?");
            string dob = Console.ReadLine();
            string welcome = string.Format("So, your name is {0}, you are {1} years old and your birthday is {2}", name, age, dob);
            Console.WriteLine(welcome);
            Console.WriteLine();
            Console.WriteLine("Press any key to close program...");
            Console.ReadKey();

        }
    }
}
