using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFWebClient.Model;

namespace WCFWebClient
{
    public partial class AddDepartmentsForm : Form
    {
        localhost.Service functionRep;
        
        public AddDepartmentsForm()
        {
            InitializeComponent();
            functionRep = new localhost.Service();
            UpdateGrid();
            
        }

        

        private async void UpdateGrid()
        {
            var dsDep = await Task<IQueryable<Department>>.Run(() =>
            {
                return (from dep in functionRep.GetListDep()
                        select new { Id = dep.Id, Name = dep.Name }).AsQueryable();

            });


            DepGrid.DataSource = dsDep.ToArray();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            localhost.Department dep = new localhost.Department()
            {
                Name = textBoxDep.Text
            };


            functionRep.CreateDep(dep);
            //empRepository.Create(emp); //////////////
            MessageBox.Show("Запись добавлена");
            UpdateGrid();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            functionRep.DeleteDep((int)DepGrid.CurrentRow.Cells[0].Value, true);
            UpdateGrid();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Department depTmp = new localhost.Department()
                {
                    Id = (int)DepGrid.CurrentRow.Cells[0].Value,
                    Name = textBoxDep.Text
                    
                };
                functionRep.UpdateDep(depTmp);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                UpdateGrid();
            }
        }
    }
}
