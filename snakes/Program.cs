using System;
using System.Collections.Generic;

namespace snakes
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1, 3, '*');
            p1.Draw();

            point p2 = new point(4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();

            numList.Add( 0 );
            numList.Add( 1 );
            numList.Add( 2 );

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }
            numList.RemoveAt(0);
            List<point> plist = new List<point>();
            plist.Add(p1);
            plist.Add(p2);
            Console.ReadLine();
        }

    }
}