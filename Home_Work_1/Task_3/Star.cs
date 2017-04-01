using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Star:BaseObject
    {
        Image img;
        string path;
        
        public Star(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
            this.path = @"C:\Work\Geekbrains\Courses\Level 2\Home_Work_1\Task_3\pictures\Patrick_Star1.png";
            this.img = Image.FromFile(this.path);

        }
        public override void Draw()
        {
            //Game.buffer.Graphics.DrawLine(Pens.White, pos.X, pos.Y, pos.X + size.Width, pos.Y + size.Height);
            //Game.buffer.Graphics.DrawLine(Pens.White, pos.X + size.Width, pos.Y, pos.X, pos.Y + size.Height);
            
            Game.buffer.Graphics.DrawImage(img, pos);
        }
        public override void Update()
        {
            pos.X = pos.X + dir.X; //справо налево
            if (pos.X < 0)
            {
                pos.X = 1000;
                pos.Y = Game.rnd.Next(0, Game.Height);
                dir.X = -Game.rnd.Next(1, 10);

            }
                

        }

        public void ResizeImage()
        {
            using (var image = Image.FromFile(@"C:\Work\Geekbrains\Courses\Level 2\Home_Work_1\Task_3\pictures\Patrick_Star.png"))
            using (var newImage = ScaleImage(image, 50, 50))
            {
                newImage.Save(@"C:\Work\Geekbrains\Courses\Level 2\Home_Work_1\Task_3\pictures\Patrick_Star1.png", ImageFormat.Png);
            }
        }
        public Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            

            return newImage;
        }

    }
}
