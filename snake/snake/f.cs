using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class f
    {
        int mw;
        int mh;
        char sym;

        Random random = new Random();

        public f(int mw, int mh, char sym)
        {
            this.mw = mw;
            this.mh = mh;
            this.sym = sym;
        }

        public point CreateFood()
        {
            int x = random.Next(2, mw - 2);
            int y = random.Next(2, mh - 2);
            return new point(x, y, sym);
        }
    }
}
