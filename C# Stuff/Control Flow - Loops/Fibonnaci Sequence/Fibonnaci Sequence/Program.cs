using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int finNumber1 = 0;
            int finNumber2 = 1;
            int sumNumber = 1;
            Console.WriteLine("Press any key to see 100 in a fibonnaci sequence: ");
            Console.ReadKey();
            while (finNumber1 < 100)
            {
                sumNumber = finNumber1 + finNumber2;
                finNumber1 = finNumber2;  //Makes finNumber1 the same value of finNumber2, so making finNumber1 the previous number constantly.
                finNumber2 = sumNumber;
                Console.WriteLine(finNumber2);
            }
            Console.ReadLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
