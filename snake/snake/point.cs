using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
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

        public point(point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void move(int offset, direction direction)
        {
            if (direction == direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == direction.UP)
            {
                y = y - offset;
            }
            else if (direction == direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool IsHit(point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void clear()
        {
            sym = ' ';
            draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
   
    }
}
