using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        
        public async Task AddGrid()
        {
            
            try
            {
                //if(Clear().GetAwaiter().GetResult())
                await UpdateGrid();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void ClearGrid()
        {
            dataGridView1.Rows.Clear();
        }
        public async Task UpdateGrid()
        {
            
                await Task.Run(() =>
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
            buttonRefrash.Enabled = false;
            
        }

        public void SetController(UrlController controller)
        {
            this.controller = controller;
        }

        private Task ReadGridAndWriteList()
        {
            return Task.Run(() =>
            {
                this.ListUrl = new List<Model.Url>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                        this.ListUrl.Add(new Model.Url(row.Cells["Url"].Value.ToString(), "", ""));


                }

            });
            
        }
        private void AddGridIsNewElement()
        {

            for (int i = 0; i < ListUrl.Count; i++)
            {
                dataGridView1.Rows.Add();

            }
            
        }

        private async void buttonExecuteResponce_Click(object sender, EventArgs e)
        {

            await ReadGridAndWriteList();
            
            await controller.MakeRequest();
            
            buttonRefrash.Enabled = true;
            
        }

        private void buttonClearGrid_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.ListUrl.Clear();
            buttonRefrash.Enabled = false;
            
        }

        private async void buttonRefrash_Click(object sender, EventArgs e)
        {
            AddGrid();
            
        }

        
        private async void buttonTestData_Click(object sender, EventArgs e)
        {

            try
            {
                await controller.ReadFile();
                ClearGrid();
                AddGridIsNewElement();
                await UpdateGrid();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}
