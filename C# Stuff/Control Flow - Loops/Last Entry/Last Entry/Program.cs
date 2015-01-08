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
                    userInput = Console.ReadLine();
                    userInputs.Add(userInput);
                    break;
                }
                userInputs.Add(userInput);
            }

            foreach (string userInput in userInputs)
            {
                Console.WriteLine(userInput);
            }
            Console.ReadKey();
        }
    }
}
