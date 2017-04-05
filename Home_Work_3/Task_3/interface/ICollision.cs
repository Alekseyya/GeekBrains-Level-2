using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    interface ICollision
{
        bool Collision(ICollision obj);
        Rectangle Rect { get; }
}

}
