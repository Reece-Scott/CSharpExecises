using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program takes your input, and reverses the output.");
            Console.WriteLine("Enter characters/words, and enter 'done' when finished");

            Stack<string> userStack = new Stack<string>();

            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLowerInvariant() == "done")
                {
                    break;
                }
                userStack.Push(userInput);
            }

            foreach (string userInput in userStack)
            {
                Console.WriteLine(userInput);
            }
            Console.ReadKey();
        }
    }
}

