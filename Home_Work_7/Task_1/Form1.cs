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
using Task_1.View;
using Task_1.Model.Repository;

namespace Task_1
{
    public partial class Form1 : Form
    {
        EmployeeRepository empRepository;
        DepartmentRepository depRepository;

        public Form1()
        {
            InitializeComponent();
            empRepository = new EmployeeRepository();
            depRepository = new DepartmentRepository();
            

            var emp_list =  (from emp in empRepository.GetList()
                             orderby emp.Name
                             select  new { EmployeeName = emp.Name, Age= emp.Age, Salary = emp.Salary}).AsQueryable();
            EmployeesGrid.DataSource = emp_list.ToList();
            

            var dep_list = (from dep in depRepository.GetList()
                            orderby dep.Name
                            select new { DepartamentName = dep.Name}).AsQueryable();

            DepartmentGrid.DataSource = dep_list.ToList();
            
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmp = new AddEmployee();
            addEmp.Show();
            
        }

        private void AddDepartment_Click(object sender, EventArgs e)
        {
            AddDepartment addDep = new AddDepartment();
            addDep.Show();
        }
    }
}
