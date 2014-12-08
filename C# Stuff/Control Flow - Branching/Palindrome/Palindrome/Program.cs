using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, welcome to the Palindrome number program");
            Console.WriteLine();
            Console.WriteLine("Please enter your number");
            int userinputNumber = Convert.ToInt32(Console.ReadLine());
            int temp = userinputNumber;
            int sum = 0;
            while (Convert.ToBoolean(userinputNumber))
            {
                int overallRemainder = userinputNumber % 10;
                userinputNumber = userinputNumber / 10;
                sum = sum * 10 + overallRemainder;
            }
            if (temp == sum)
            {
                Console.WriteLine("The Number Is A Palindrome");
            }
            else
            {
                Console.WriteLine("The Number Is Not A Palindrome");
            }
            Console.ReadKey();

        }
    }
}
