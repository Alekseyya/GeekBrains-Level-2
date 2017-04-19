using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Test7; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string createExpression = @"CREATE TABLE[dbo].[People] (
                                    [Id] INT IDENTITY(1, 1) NOT NULL,
                                    [FIO] NVARCHAR(MAX) COLLATE Cyrillic_General_CI_AS NOT NULL,
                                    [Birthday] NVARCHAR(MAX) NULL,
                                    [Email]    NVARCHAR(100) NULL,
                                    [Phone]    NVARCHAR(MAX) NULL,
                                    CONSTRAINT[PK_dbo.People] PRIMARY KEY CLUSTERED([Id] ASC)
                                );";
            string sqlExpression = @"INSERT INTO People (FIO, Birthday,Email,Phone) VALUES ('Иванов Иван Иванович', '18.10.2001', 'somebody@gmail.com', '89164444444' );
                                     INSERT INTO People(FIO, Birthday, Email, Phone) VALUES('Петров Петр Петрович', '15.01.2001', 'somebody@mail.com', '8916555555')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(createExpression, connection);
                int number = command.ExecuteNonQuery();

                command = new SqlCommand(sqlExpression, connection);
                number = command.ExecuteNonQuery();
                labelResultCreate.Text = number.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT * FROM People";
            listViewPeople.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                       var l = new ListViewItem(reader.GetValue(0).ToString());

                        l.SubItems.Add(reader.GetValue(1).ToString());
                        l.SubItems.Add(reader.GetValue(2).ToString());
                        listViewPeople.Items.Add(l);
                    }
                }

                reader.Close();
            }                   

        }
       private void buttonProcedure_Click(object sender, EventArgs e)
        {
            string sqlExpression = "[dbo].[sp_GetPeople]";

            listViewPeople.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {              

                    while (reader.Read())
                    {
                        var l = new ListViewItem(reader.GetInt32(0).ToString());

                        l.SubItems.Add(reader.GetString(1).ToString());
                        l.SubItems.Add(reader.GetString(2).ToString());
                        listViewPeople.Items.Add(l);
                    }
                }
                reader.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT COUNT(*) FROM People";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                labelCount.Text = command.ExecuteScalar().ToString();            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM People";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridViewPeople.DataSource = ds.Tables[0];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM People";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                // добавим новую строку
                DataRow newRow = dt.NewRow();
                newRow["FIO"] = "Александров Александр Александрович";
                newRow["Birthday"] = "25.04.2002";
                dt.Rows.Add(newRow);

                // создаем объект SqlCommandBuilder
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(ds);
  
                ds.Clear();
                // перезагружаем данные
                adapter.Fill(ds);

                dataGridViewPeople.DataSource = ds.Tables[0];

                MessageBox.Show(commandBuilder.GetUpdateCommand().CommandText + "\n" + 
                                commandBuilder.GetInsertCommand().CommandText + "\n" + 
                                commandBuilder.GetDeleteCommand().CommandText);;
            }
        }
    }
}
