using System;
using System.Collections.Generic;
using System.Text;

namespace snakes
{
    class Figure
    {
        protected List<point> pList;

        public void Draw()
        {
            foreach (point p in pList)
            {
                p.Draw();
			}
		}

		internal bool IsHit(Figure figure)
		{
			foreach (var p in pList)
			{
				if (figure.IsHit(p))
					return true;
			}
			return false;
		}

		private bool IsHit(point point)
		{
			foreach (var p in pList)
			{
				if (p.IsHit(point))
					return true;
			}
			return false;
		}
	}
}
