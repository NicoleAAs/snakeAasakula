using System;
using System.Collections.Generic;

namespace snakes
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = null;
            Console.SetWindowSize(80, 27);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            DownLine.Drow();
            leftLine.Drow();
            rightLine.Drow();
            //Отрисовка точек
            point p = new point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();

            //while (true)
            //{
            //    if (Console.KeyAvailable)
            //    {
            //        ConsoleKeyInfo key = Console.ReadKey();
            //        snake.HandleKey(key.Key);
            //    }

            //}


            //Создание еды для змейки
            FoodCreator foodcreator = new FoodCreator(80, 25, 'o');
            point food = foodcreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodcreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                System.Threading.Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                 }                           
            }
        }
    }
