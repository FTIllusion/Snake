using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake :Figure
    {
        Direction direction;

        public Snake (Point tail, int leght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();

            for(int i = 0; i < leght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey Key)
        {
            if (Key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (Key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (Key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (Key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
        }

        internal bool headOnHit(Point food)
        {
            Point nextPoint = GetNextPoint();
            if (food.x == nextPoint.x && food.y == nextPoint.y)
            {
                food.Clear();
                food.sym = '*';
                food.Draw();
                pList.Add(food);
                return true;
            }
                
            else
                return false;

                
        }

    }
}
