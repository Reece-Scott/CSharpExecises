using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Entry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> userInputs = new List<string>();

            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLowerInvariant() == "done")
                {
                    break;
                }
                userInputs.Add(userInput);
            }
            Console.WriteLine("Enter text to search for: ");
            string finalUserInput = Console.ReadLine();

            foreach (string userInput in userInputs)
            {
                if (userInput.Contains(finalUserInput))
                    Console.WriteLine(userInput);
            }
            Console.ReadKey();
        }
    }
}
