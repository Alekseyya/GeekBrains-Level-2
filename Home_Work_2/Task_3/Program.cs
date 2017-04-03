using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Ярчук Алексей

/// <summary>
/// Переработать игру «Астероиды» из методички. Создать свои объекты, 
/// чтобы реализовать эффект полёта в звёздном пространстве 
/// (объекты движутся от центра к краям экрана).
/// </summary>
/// 1.	Добавить свои объекты в иерархию объектов, чтобы получился красивый задний фон, 
/// похожий на полёт в звёздном пространстве.
///2.	* Заменить кружочки картинками, используя метод DrawImage.
///3.	**Разработать собственный класс Screensaver, аналогичный классу Game.


namespace Task_3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form form = new Form();
            form.Width = 800;
            form.Height = 600;
            Game.Init(form);
            form.Show();
            Game.Draw();
            Application.Run(form);
            

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
