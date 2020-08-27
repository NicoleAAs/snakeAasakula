using System;
using System.Collections.Generic;
using System.Text;

namespace snakes
{
    class Figure
    {
        protected List<point> pList;

        public virtual void Draw()
        {
            foreach (point p in pList)
            {
                p.Draw();
            }
        }

		}


	}

