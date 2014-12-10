using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentLargestNumber = Int32.MinValue;
            int currentSmallestNumber = Int32.MaxValue;

            for (int i = 0; i < 10; i++ )
            {
                Console.WriteLine("Your number:");
                string userInputNumber = Console.ReadLine();
                int userNumber = int.Parse(userInputNumber);

               if (userNumber > currentLargestNumber)
                {
            currentLargestNumber = userNumber;      //currentLArgestNumber begins at 0, so first number user inputs will then be classed as the largest.
                }                                   //This loops 10 times to find the largest number.


               if (userNumber < currentSmallestNumber)  //This does the same as the largest number calculation, but in reverse.
               {
                   currentSmallestNumber = userNumber;
               }
            }
        Console.WriteLine("Large Number: {0}   Smallest Number: {1}", currentLargestNumber, currentSmallestNumber);

        Console.ReadKey();
        }

       }
    }
