using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();
            */

            Console.SetBufferSize(80, 25);

            HorizontalLine hLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine hLine2 = new HorizontalLine(0, 78, 23, '+');
            VerticalLine vLine = new VerticalLine(0, 22, 0, '+');
            VerticalLine vLine2 = new VerticalLine(0, 22, 78, '+');

            vLine.Drow();
            vLine2.Drow();
            hLine.Drow();
            hLine2.Drow();

            Point p = new Point(4, 5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            Console.ReadLine();
        }

    }
}
