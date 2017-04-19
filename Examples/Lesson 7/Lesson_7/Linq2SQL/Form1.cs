using System;
using System.Data.Linq;
using System.Windows.Forms;
using Linq2SQL.Model;
using System.Linq;

namespace Linq2SQL
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Test7; Integrated Security = True";
        DataContext db;
        public Form1()
        {
            InitializeComponent();
            db = new DataContext(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            // Получаем таблицу пользователей
            Table<People> users = db.GetTable<People>();
            dataGridView.DataSource = users;
            dataGridView.Update();
            dataGridView.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Table<People> people = db.GetTable<People>();
            var query = db.GetTable<People>().Where(u => u.Birthday == "15.01.2001");

            query = from u in db.GetTable<People>()
                    where u.Birthday == "15.01.2001"
                    orderby u.FIO
                    select u; 

            dataGridView.DataSource = query;
            dataGridView.Update();
            dataGridView.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            People people1 = new People { FIO = "Тимофеев Тимофей Тимофеевич", Birthday = "01.03.1999" };
            // добавляем его в таблицу People
            db.GetTable<People>().InsertOnSubmit(people1);
            db.SubmitChanges();
            dataGridView.DataSource = db.GetTable<People>();
            dataGridView.Update();
            dataGridView.Refresh();
        }
    }
}
