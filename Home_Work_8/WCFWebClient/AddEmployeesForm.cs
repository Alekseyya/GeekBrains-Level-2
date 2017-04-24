using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFWebClient.Model;

namespace WCFWebClient
{
    public partial class AddEmployeesForm : Form
    {
        localhost.Service functionRep;
        public AddEmployeesForm()
        {
            InitializeComponent();
            functionRep = new localhost.Service();
            UpdateGrid();

            

        }

        private async void UpdateGrid()
        {
            
            var dsEmp = await Task<IQueryable<Employee>>.Run(() =>
            {
                return (from emp in functionRep.GetListEmp()
                        select new { Id = emp.Id, Name = emp.Name, Age = emp.Age, Salary = emp.Salary }).AsQueryable();

            });


            EmpGrid.DataSource = dsEmp.ToArray();
            
            EmpGrid.SelectionChanged += Select;
        }
        public async void Select(object obj, EventArgs e)
        {
            DataGridView grid = (DataGridView)obj;
            var employee = await Task<Employee>.Run(() => { return functionRep.GetItemEmp((int)grid.CurrentRow.Cells[0].Value, true); });
            if (employee != null)
            {
                textBoxName.Text = employee.Name;
                //Поиск id по имени
                //var t = depRepository.GetList().FirstOrDefault(x => x.Id == employee.DepartmentId).Name;
                comboBoxDep.Items.AddRange(functionRep.GetListDep().Select(idDep => idDep.Name).ToArray());
                comboBoxDep.SelectedItem = functionRep.GetListDep().FirstOrDefault(x => x.Id == employee.DepartmentId).Name;
                textBoxAge.Text = employee.Age.ToString();
                textBoxSalary.Text = employee.Salary.ToString();

            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            localhost.Employee emp = new localhost.Employee()
            {
                Name = textBoxName.Text,
                DepartmentId = functionRep.GetListDep().FirstOrDefault(name => name.Name == comboBoxDep.SelectedItem).Id,
                Age = Convert.ToInt32(textBoxAge.Text),
                Salary = Convert.ToInt32(textBoxSalary.Text)
            };
            

            functionRep.CreateEmp(emp);
            //empRepository.Create(emp); //////////////
            MessageBox.Show("Запись добавлена");
            UpdateGrid();
            EmpGrid.Refresh();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            functionRep.DeleteEmp((int)EmpGrid.CurrentRow.Cells[0].Value,true);
            EmpGrid.Update();
            EmpGrid.Refresh();
            UpdateGrid();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Employee empTmp = new localhost.Employee()
                {
                    Id = (int)EmpGrid.CurrentRow.Cells[0].Value,
                    Name = textBoxName.Text,
                    Age = Convert.ToInt32(textBoxAge.Text),
                    Salary = Convert.ToInt32(textBoxSalary.Text)
                };
                functionRep.UpdateEmp(empTmp);
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
