using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Asteroid: BaseObject
    {
        int power;

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public Asteroid(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
            Power = 1;
        }

        public override void Draw()
        {
            Game.buffer.Graphics.FillEllipse(Brushes.Wheat, pos.X, pos.Y, size.Width, size.Height);
        }
        public override void Update()
        {
            pos.X = pos.X + dir.X;
            if (pos.X < 0) 
            {
                pos.X = 1000;
                pos.Y = Game.rnd.Next(0, Game.Height);
                dir.X = -Game.rnd.Next(1, 10);
            }
        }
    }
}
