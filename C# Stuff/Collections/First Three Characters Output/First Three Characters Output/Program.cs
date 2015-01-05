using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Three_Characters_Output
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> userInputs = new List<string>();
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLowerInvariant()=="done")
                {
                    break;
                }
                userInputs.Add(userInput);
            }
            foreach (string userInput in userInputs)
            {
                Console.WriteLine(userInput.Substring(0, 3));
            }
            
        }
    }
}