using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            vl vl = new vl(0, 10, 5, '%');
            draw(vl);

            point p = new point(4, 5, '*');
            fig fSnake = new snake(p, 4, direction.RIGHT);
            draw(fSnake);
            snake snake = (snake)fSnake;

            hl hl = new hl(0, 5, 6, '&');

            List<fig> figures = new List<fig>();
            figures.Add(fSnake);
            figures.Add(vl);
            figures.Add(hl);

            foreach(var f in figures)
            {
                f.draw();
            }

            static void draw(fig figure)
            {
                figure.draw();
            }
            /* Console. SetBufferSize(80, 25);

            hl uline = new hl(0,78,0,'+');
            hl dline = new hl(0,78,24,'+');
            vl lline = new vl(0,24,0,'+');
            vl rline = new vl(0,24,78,'+');
            uline.draw();
            dline.draw();
            lline.draw();
            rline.draw();

            point p = new point(4, 5, '*');
            snake snake = new snake(p, 4 , direction.RIGHT);
            snake.draw();

            f f = new f(80, 25, '$');
            point food = f.CreateFood();
            food.draw();
          
              while(true)
            {
                if(snake.eat(food))
                {
                    food = f.CreateFood();
                    food.draw();
                }
                else
                {
                    snake.move();
                }

                Thread.Sleep(150);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.handlkey(key.Key);
                }
                Thread.Sleep(150);
                snake.move();
            } */

        }
    }
}
