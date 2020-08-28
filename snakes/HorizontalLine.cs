using System;
using System.Collections.Generic;
using System.Text;

namespace snakes
{
    class HorizontalLine : Figure
    {
        
        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            pList = new List<point>();
            for (int x = xLeft; x <= xReight; x++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);

            }
        }

    }
}
