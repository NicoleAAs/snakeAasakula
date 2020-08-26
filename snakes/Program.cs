using System;
using System.Collections.Generic;

namespace snakes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 27);
            
            



            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            DownLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            point p = new point(4, 5, '*');
            p.Draw();
            //point p1 = new point(1, 3, '*');
            //p1.Draw();

            //point p2 = new point(4, 5, '#');
            //p2.Draw();

            //HorizontalLine line = new HorizontalLine(5 , 10 , 8 , '+');
            //line.Drow();


            //Console.ReadLine();
        }

    }
}