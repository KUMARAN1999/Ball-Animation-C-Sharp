using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace _16CS125_Ball
{
    class Ball
    {
        Random random = new Random();
        int x, y, vx, vy, size;
        Brush b;

        public Ball(int _x, int _y, int _vx, int _vy, int _size)
        {
            x = _x;
            y = _y;
            vx = _vx;
            vy = _vy;
            size = _size;
        }

        public void MoveBall(int _width, int _height)
        {
            x += vx;
            y += vy;
            if (x > _width - size || x < 0)
            {

                vx = -vx;
            }
            if (y > _height - size || y < 0)
            {
                vy = -vy;
            }
        }

        public void Draw(Graphics g, Brush b)
        {
            g.FillEllipse(b, x, y, size, size);
        }
    }
}
