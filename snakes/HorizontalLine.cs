using System;
using System.Collections.Generic;
using System.Text;

namespace snakes
{
    class HorizontalLine
    {
        List<point> pList;

        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            pList = new List<point>();
            for (int x = xLeft; x <= xReight; x++ )
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }
          
        }
        public void Drow()
        {
            foreach (point p in pList )
            {
                p.Draw();
            }
        }

    }
}
