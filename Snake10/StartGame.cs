using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake10
{
    class StartGame
    {
        public static void Start(int time)
        {
            {
                
                Random t = new Random();
                Snake snake = new Snake(t.Next(1, 39), t.Next(1, 19), (Direction)t.Next(0, 4));
                Point apple = new Point(t.Next(1, 39), t.Next(1, 19));

                while (true)
                {
                    while (!Console.KeyAvailable)
                    {
                        Console.Clear();
                        PoleStart.PrintPole(ConsoleColor.Blue);
                        PrintPoint(apple, 'O', ConsoleColor.Green);
                        PrintSnake(snake);
                        Thread.Sleep(time);
                        snake.Move();

                        if (snake.Heat.X == apple.X && snake.Heat.Y == apple.Y)
                        {
                            snake.Eat(apple);
                            apple = new Point(t.Next(1, 39), t.Next(1, 19));
                        }
                        if (snake.Heat.X == 40 || snake.Heat.X == 0 || snake.Heat.Y == 20 || snake.Heat.Y == 0)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(50, 10);
                            Console.WriteLine("Game over");
                            break;
                        }
                    }
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.UpArrow && snake.Direction != Direction.Down)
                    {
                        snake.Direction = Direction.Up;
                    }
                    else if (key.Key == ConsoleKey.DownArrow && snake.Direction != Direction.Up)
                    {
                        snake.Direction = Direction.Down;
                    }
                    else if (key.Key == ConsoleKey.LeftArrow && snake.Direction != Direction.Right)
                    {
                        snake.Direction = Direction.Left;
                    }
                    else if (key.Key == ConsoleKey.RightArrow && snake.Direction != Direction.Left)
                    {
                        snake.Direction = Direction.Right;
                    }
                }
            }
            
        }
        public static void PrintPoint(Point point, char c, ConsoleColor color)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }
        public static void PrintSnake(Snake snake)
        {
            foreach (var item in snake.Points)
            {
                PrintPoint(item, '*', ConsoleColor.Red);
            }
        }
    }
}
