using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake10
{
    class Level
    {
        public int Time { get; set; }
        public Level(int time)
        {
            this.Time = time;
        }
        public static void LevelUser(int time)
        {
            Console.Clear();
            string[] menuItems = new string[] { "Level 1", "Level 2", "Level 3" };
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("User Level");
            Console.WriteLine();
            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            while (true)
            {
                DrawMenu(menuItems, row, col, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItems.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (index)
                        {
                            case 0:
                                time = 500;
                                StartGame.Start(time);
                                break;
                            case 1:
                                time = 200;
                                StartGame.Start(time);
                                break;
                            case 2:
                                time = 100;
                                StartGame.Start(time);
                                break;
                        }
                        break;

                }
            }
        }
        public static void DrawMenu(string[] items, int row, int col, int index)
        {
            Console.SetCursorPosition(col, row);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.SetCursorPosition(20, 5 + i);
                Console.WriteLine(items[i]);
                Console.ResetColor();

            }
            Console.WriteLine();
        }
    }
}
