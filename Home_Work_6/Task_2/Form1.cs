using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_2.Controllers;

namespace Task_2
{
    public partial class Form1 : Form
    {
        UrlController controller;
        

        public Form1()
        {
            InitializeComponent();
            buttonRefrash.Enabled = false;
            
        }
        public List<Model.Url> ListUrl { get; set; }

        static object locker = new object();
        public async void AddGrid()
        {

            
            await UpdateGrid();



        }

        private Task Clear()
        {
            return Task.Run(() =>
            {
                while (dataGridView1.Rows.Count >= 1)
                {
                    dataGridView1.Rows.RemoveAt(0);

                }

            });
        }
        private Task UpdateGrid()
        {
            
                return Task.Run(() =>
                {
                    int index = 0;
                    foreach (var url in ListUrl)
                    {
                        
                        dataGridView1.Rows[index].Cells["Url"].Value = url.Name;
                        dataGridView1.Rows[index].Cells["Error"].Value = url.ErrorOrLength;
                        dataGridView1.Rows[index].Cells["Response"].Value = url.StopWatch;
                        index++;
                    }

                });
            
            
        }
        
        private void buttonAddUrl_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(textBoxUrl.Text);
            textBoxUrl.Clear();
            
        }

        public void SetController(UrlController controller)
        {
            this.controller = controller;
        }


        private void buttonExecuteResponce_Click(object sender, EventArgs e)
        {
            this.ListUrl = new List<Model.Url>();
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(!row.IsNewRow)
                    this.ListUrl.Add(new Model.Url(row.Cells["Url"].Value.ToString(), "", ""));
                
                
            }
           
           controller.MakeRequest();
           buttonRefrash.Enabled = true;
            
        }

        private void buttonClearGrid_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.ListUrl.Clear();
            
        }

        private void buttonRefrash_Click(object sender, EventArgs e)
        {
            AddGrid();
        }
    }
}
