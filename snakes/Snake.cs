using System;
using System.Collections.Generic;
using System.Text;

namespace snakes
{
    class Snake : Figure
    {
        public Snake(point tail, int length, Direction direction)
         {
            pList = new List<point>();
             for(int i = 0; i < length; i++)
             {
                point p = new point(tail);
                p.Move( i, direction );
                pList.Add(p);

              }
        }
    }
}
