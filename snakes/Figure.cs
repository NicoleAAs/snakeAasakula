using System;
using System.Collections.Generic;
using System.Text;

namespace snakes
{
    class Figure
    {
        protected List<point> pList;

        public void Drow()
        {
            foreach (point p in pList)
            {
                p.Draw();
            }
        }

        public point GetNextPoint()
    }
}
