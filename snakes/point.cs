using System;
using System.Collections.Generic;
using System.Text;

namespace snakes
{
    class point
    {
        public int x;
        public int y;
        public char sym;
        public point()
        {
        }
        public point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
