using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_A_Square
{
    class Program
    {
        static void Main(string[] args)
        {
         int squareSize;
            while (true)
            {
                Console.Write("Please enter side length : ");
                int.TryParse(Console.ReadLine(), out squareSize);
                if (squareSize > 0) break;
            }
            DrawSquare(squareSize);
            Console.ReadKey();
        }
        static void DrawSquare(int side)
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

        
    

