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
    public partial class Information : Form
    {
        localhost.Service functionRepo;
        public Information()
        {
            InitializeComponent();
            functionRepo = new localhost.Service();
            UpdateGrid();


        }

        public async void UpdateGrid()
        {
            var dsEmp = await Task<IQueryable<Employee>>.Run(() =>
            {
                return (from emp in functionRepo.GetListEmp()
                        select new { Id = emp.Id, Name = emp.Name, Age = emp.Age, Salary = emp.Salary }).AsQueryable();

            });


            EmpGrid.DataSource = dsEmp.ToArray();

            var dsDep = await Task<IQueryable<Department>>.Run(() =>
            {
                return (from dep in functionRepo.GetListDep()
                        select new { Id = dep.Id, Name = dep.Name }).AsQueryable();

            });


            DepGrid.DataSource = dsDep.ToArray();

        }

        private void AddEmp_Click(object sender, EventArgs e)
        {

            AddEmployeesForm addEmpForm = new AddEmployeesForm();
            addEmpForm.Show();
        }

        private void AddDep_Click(object sender, EventArgs e)
        {
            AddDepartmentsForm addDepForm = new AddDepartmentsForm();
            addDepForm.Show();
        }
    }
}
