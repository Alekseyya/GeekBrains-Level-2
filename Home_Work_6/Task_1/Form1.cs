using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Test();
        }

        public void Test()
        {
            BookRepository repo = new BookRepository();
            repo.Create(new Book { Id = 1, Author = "Boris", Name = "Voina imir", Price = 600 });
            repo.Create(new Book { Id = 2, Author = "Moris", Name = "Voina imir", Price = 600 });
            repo.Create(new Book { Id = 3, Author = "Gris", Name = "Voina imir", Price = 600 });

            repo.Delete(new Book { Id = 2 });
            repo.Update(new Book { Id = 1, Author = "AAAA" });
            var m = 0;
        }
    }
}
