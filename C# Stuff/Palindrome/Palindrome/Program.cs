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
            int userinputNumber;
            int overallRemainder;
            int sum = 0;
            int temp;

            Console.WriteLine("Hello, welcome to the Palindrome number program");
            Console.WriteLine();
            Console.WriteLine("Please enter your number");
            userinputNumber = Convert.ToInt32(Console.ReadLine());
            temp = userinputNumber;

            while (Convert.ToBoolean(userinputNumber))
            {
                overallRemainder = userinputNumber % 10;
                userinputNumber = userinputNumber / 10;
                sum = sum * 10 + overallRemainder;
            }
            Console.WriteLine("The Reversed Value Is: {0}", sum);

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
