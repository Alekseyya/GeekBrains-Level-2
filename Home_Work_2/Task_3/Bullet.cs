﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Bullet : BaseObject
    {
        public Bullet(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }

        public override void Draw()
        {
            Game.buffer.Graphics.FillRectangle(SystemBrushes.MenuBar, pos.X, pos.Y, size.Width, size.Height);
        }

        public override void Update()
        {
            //Скорость пули
            pos.X = pos.X + 20;

        }
    }
}
