using System;
using System.Collections.Generic;
using System.Text;

namespace snakes
{
    class VerticalLine
    {
        List<point> pList;

        public VerticalLine( int yUp, int yDown, int x, char sym)
        {
            pList = new List<point>();
            for(int y = yUp; y <= yDown; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }
        }
        public void Drow()
        {
            foreach(point p in pList)
            {
                p.Draw();
            }
        }
    }
}
