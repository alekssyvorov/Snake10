using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Random t = new Random();
            Snake snake = new Snake(t.Next(1, 39), t.Next(1, 19), (Direction)t.Next(0, 4));
            Point apple = new Point(t.Next(1, 39), t.Next(1, 19));

            Menu.MenuUser();
        }
    }
}
