using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    //Движение объкутов
    abstract class BaseObject : ICollision
    {
        

        // Так и не понял почему он не работает у меня не работает логер. В файле assemblyifo  подключил, потом в App.config тоже
        // создал такой экземляр
        public static readonly ILog log = LogManager.GetLogger(typeof(BaseObject));
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

        public bool Collision(ICollision o)
        {
            if (o.Rect.IntersectsWith(this.Rect))
            {

                
                //должен быть вывод в файл логов
                log4net.LogicalThreadContext.Properties["X"] = Rect.X.ToString();
                log4net.LogicalThreadContext.Properties["Y"] = Rect.Y.ToString();
                log4net.LogicalThreadContext.Properties["objectX"] = o.Rect.X.ToString();
                log4net.LogicalThreadContext.Properties["objectY"] = o.Rect.Y.ToString();
                log.Info("Collosion");
                return true;
            }
            return false;
           
            
        }
        

    }
}
