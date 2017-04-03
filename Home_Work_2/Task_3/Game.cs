using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    static class Game
    {
        
        static BaseObject[] objs;
        
        static Asteroid[] asteroids;

        static BufferedGraphicsContext context;
        static public BufferedGraphics buffer;
        static public Random rnd = new Random();
        static Bullet bullet;

        static Shantle shatle = new Shantle(new Point(10, 400), new Point(5, 5), new Size(10, 10));

        // Свойства
        // Ширина и высота игрового поля
        static public int Width { get; set; }
        static public int Height { get; set; }
        static Game()
        {
        }
        static public void Init(Form form)
        {

            //обработка события коробля
            form.KeyDown += Form_KeyDown;
            // Графическое устройство для вывода графики            
            Graphics g;
            // предоставляет доступ к главному буферу графического контекста для текущего приложения
            context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();// Создаём объект - поверхность рисования и связываем его с формой
                                      // Запоминаем размеры формы
            Width = form.Width;
            Height = form.Height;
            // Связываем буфер в памяти с графическим объектом.
            // для того, чтобы рисовать в буфере
            buffer = context.Allocate(g, new Rectangle(0, 0, Width, Height));

            Load();
            
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Start();
            timer.Tick += Timer_Tick;

        }

        private static void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) shatle.Up();
            if (e.KeyCode == Keys.Down) shatle.Down();
            if (e.KeyCode == Keys.Right) shatle.Right();
            if (e.KeyCode == Keys.Left) shatle.Left();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
            Update();
        }
        /// <summary>
        /// Рисует все объекты
        /// </summary>
        static public void Draw()
        {
            // Проверяем вывод графики
            buffer.Graphics.Clear(Color.Black);
            foreach (BaseObject obj in objs)
                obj.Draw();
            foreach (Asteroid obj in asteroids)
                obj.Draw();
            shatle.Draw();
            buffer.Render();

        }
        /// <summary>
        /// Задаются все координаты для объектов
        /// </summary>
        static public void Load()
        {
            
           
            //Звезды
            objs = new BaseObject[30];
            for (int i = 0; i < objs.Length; i++)
            {
                int r = rnd.Next(5, 50);
                objs[i] = new Star(new Point(500, Game.rnd.Next(0, Game.Height)), new Point(-r, 0), new Size(3, 3));
            }
            //Астероиды
            asteroids = new Asteroid[3];
            for (int i = 0; i < asteroids.Length; i++)
            {
                int r = rnd.Next(5, 50);
                asteroids[i] = new Asteroid(new Point(800, Game.rnd.Next(0, Game.Height)), new Point(-5, 0), new Size(r, r));
            }

        }
        /// <summary>
        /// Обновление всех объектов
        /// </summary>
        static public void Update()
        {
            foreach (BaseObject obj in objs)
                obj.Update();
            foreach (Asteroid obj in asteroids)
            {
                obj.Update();
                
            }
            shatle.Update();
        }


    }
}
