using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake10
{
    class Menu
    {
        public static void MenuUser()
        {
            string[] menuItem = new string[] { "Start Game", "Level Game", "Exit Game" };
            int temp = 0;
            Console.CursorVisible = false;
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("Menu Game");

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            int time = 500;
            while (true)
            {
                DrawMenu(menuItem, row, col, index, temp, time);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItem.Length - 1)
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
                                StartGame.Start(time);
                                return;
                            case 1:
                                temp++;
                                break;
                        }
                        break;
                }
            }
            Console.ReadLine();
        }
        public static void DrawMenu(string[] items, int row, int col, int index, int temp, int time)
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
                if (temp > 0)
                {
                    Level.LevelUser(time);
                }

            }
            Console.WriteLine();
        }
    }
}
