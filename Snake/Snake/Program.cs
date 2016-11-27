using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

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

            FoodCreator foodCreator = new FoodCreator(78, 22, '$');
            Point foodPoint = foodCreator.CreateFood();
            foodPoint.Draw();

            while (true)
            {


                Console.SetCursorPosition(1, 22);
                Console.WriteLine(rand.Next(2, 22 - 2));
                if (snake.headOnHit(foodPoint))
                {
                    do
                    {
                        foodPoint = foodCreator.CreateFood();
                        

                    } while (foodPoint.sym == '*');
                    foodPoint.Draw();
                }

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                Thread.Sleep(100);
                snake.Move();
            }
        }

    }
}
