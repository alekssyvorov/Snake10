using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake10
{
    class PoleStart
    {
        internal static void PrintPole(ConsoleColor color)
        {
            int line = 20, columns = 40;
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i==0 | j==0 | i == line - 1 | j == columns - 1)
                    {
                        Console.ForegroundColor = color;
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
