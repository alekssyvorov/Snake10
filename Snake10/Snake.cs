using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake10
{
    class Snake
    {
        public Point Heat
        {
            get
            {
                return Points[0];
            }
        }
        public List<Point> Points { get; set; }

        public Direction Direction { get; set; }

        public void Eat(Point apple)
        {
            Points.Insert(0, apple);
        }

        public Snake(int x, int y, Direction direction)
        {
            this.Points = new List<Point>();
            this.Points.Add(new Point(x, y));
            this.Direction = Direction;
        }

        public void Move()
        {
            for (int i = Points.Count-1; i >= 0; i--)
            {
                if(i == 0)
                {
                    switch (Direction)
                    {
                        case Direction.Down:
                            Points[i].Y++;
                            break;
                        case Direction.Up:
                            Points[i].Y--;
                            break;
                        case Direction.Left:
                            Points[i].X--;
                            break;
                        case Direction.Right:
                            Points[i].X++;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Points[i].X = Points[i - 1].X;
                    Points[i].Y = Points[i - 1].Y;
                }
            }
        }

    }
}
