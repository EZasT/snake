using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class vl : fig
    {
        public vl(int xup, int xdown, int x, char sym)
        {
            pList = new List<point>();
            for (int y = xup; y <= xdown; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }

        }
    }
}
