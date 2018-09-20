using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class fig
    {
        protected List<point> pList;


        public virtual void draw()
        {
            foreach (point p in pList)
            {
                p.draw();
            }
        }
    }
}
