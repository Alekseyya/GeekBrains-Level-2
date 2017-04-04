using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    class Shantle: BaseObject
    {
        //Form form = new Form();
        public Shantle(Point pos, Point dir, Size size) : base(pos, dir, size)
        {

        }
        public override void Draw()
        {
            Game.buffer.Graphics.DrawRectangle(Pens.OrangeRed, pos.X, pos.Y, size.Width, size.Height);
        }

        public override void Update()
        {
            
        }

               
        public void Up()
        {
            if (pos.Y > 20)
                pos.Y = pos.Y - dir.Y;
        }
        public void Down()
        {
            if (pos.Y < Game.Height - 20)
                pos.Y = pos.Y + dir.Y;
        }

        public void Left()
        {
            if (pos.X > 20)
                pos.X = pos.X - dir.X;
        }

        public void Right()
        {
            if (pos.X < Game.Width - 20)
                pos.X = pos.X + dir.X;
        }
    }
}
