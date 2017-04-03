using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    //Движение объкутов
    public abstract class BaseObject
    {
        protected Point pos;
        protected Point dir;
        protected Size size;

        public Rectangle Rect
        {
            get { return new Rectangle(pos, size); }
        }
        public BaseObject(Point pos, Point dir, Size size)
        {
            this.pos = pos;
            this.dir = dir;
            this.size = size;
        }
        public abstract void Draw();
        //{
        //    Game.buffer.Graphics.DrawEllipse(Pens.White, pos.X, pos.Y, size.Width, size.Height);
        //}
        public abstract void Update();
        //{
        //    pos.X = pos.X + dir.X;
        //    pos.Y = pos.Y + dir.Y;
        //    if (pos.X < 0) dir.X = -dir.X;
        //    if (pos.X > Game.Width) dir.X = -dir.X;
        //    if (pos.Y < 0) dir.Y = -dir.Y;
        //    if (pos.Y > Game.Height) dir.Y = -dir.Y;
        //}

    }
}
