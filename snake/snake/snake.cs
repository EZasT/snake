using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class snake : fig
    {
        direction direction;
        public snake(point tail, int lenght, direction _direction)
        {
            direction = _direction;
            pList = new List<point>();
            for (int i = 0; i < lenght; i++)
            {
                point p = new point(tail);
                p.move(i, direction);
                pList.Add(p);
            }
        }

        internal void move()
        {
            point tail = pList.First();
            pList.Remove(tail);
            point head = GetNextPoint();
            pList.Add(head);

            tail.clear();
            head.draw();
        }
        public point GetNextPoint()
        {
            point head = pList.Last();
            point nextpoint = new point(head);
            nextpoint.move(1, direction);
            return nextpoint;
        }
        public void handlkey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = direction.UP;

      
    }

        internal bool eat(point food)
        {
            point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}