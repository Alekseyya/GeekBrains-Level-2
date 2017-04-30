using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_1.Model;
using Task_1.Model.Repository;

namespace Task_1.View
{
    public partial class AddEmployee : Form
    {
        EmployeeRepository empRepository;
        BindingSource bs = new BindingSource();
        DepartmentRepository depRepository;

        public AddEmployee()
        {
            InitializeComponent();
            empRepository = new EmployeeRepository();
            depRepository = new DepartmentRepository();

            UpdateGrid();
            EmployeesGrid.SelectionChanged += Select;
            

        }
        private void UpdateGrid()
        {
            var emp_list = (from emp in empRepository.GetList()
                            orderby emp.Name
                            select new { Id = emp.Id, EmployeeName = emp.Name, Age = emp.Age, Salary = emp.Salary }).AsQueryable();

            EmployeesGrid.DataSource = emp_list.ToList();
            
        }
        public void Select(object obj, EventArgs e)
        {
            DataGridView grid = (DataGridView)obj;
            Employee employee = empRepository.GetItem((int)grid.CurrentRow.Cells[0].Value);
            if (employee != null)
            {
                Name.Text = employee.Name;
                //Поиск id по имени
                //var t = depRepository.GetList().FirstOrDefault(x => x.Id == employee.DepartmentId).Name;
                DepId.Items.AddRange(depRepository.GetList().Select(idDep => idDep.Name).ToArray());
                DepId.SelectedItem = depRepository.GetList().FirstOrDefault(x => x.Id == employee.DepartmentId).Name;
                Age.Text = employee.Age.ToString();
                Salary.Text = employee.Salary.ToString();

            }
            
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            Name.Clear();
            Age.Clear();
            Salary.Clear();

        }
       

        private void AddEployees_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee()
            {
                Name = Name.Text,
                DepartmentId = depRepository.GetList().FirstOrDefault(name => name.Name == DepId.SelectedItem).Id,
                Age = Convert.ToInt32(Age.Text),
                Salary = Convert.ToInt32(Salary.Text)
            };

            empRepository.Create(emp);
            MessageBox.Show("Запись добавлена");
            UpdateGrid();
            EmployeesGrid.Refresh();
        }

        private void DeleteSelectEmployee_Click(object sender, EventArgs e)
        {
            
            empRepository.Delete((int)EmployeesGrid.CurrentRow.Cells[0].Value);
            EmployeesGrid.Update();
            EmployeesGrid.Refresh();
            UpdateGrid();
           
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                Employee empTmp = new Employee()
                {
                    Id = (int)EmployeesGrid.CurrentRow.Cells[0].Value,
                    Name = Name.Text,
                    Age = Convert.ToInt32(Age.Text),
                    Salary = Convert.ToInt32(Salary.Text)
                };
                empRepository.Update(empTmp);
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
