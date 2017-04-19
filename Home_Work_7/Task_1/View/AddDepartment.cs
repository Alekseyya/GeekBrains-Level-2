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
    public partial class AddDepartment : Form
    {
        DepartmentRepository depRepository;
        public AddDepartment()
        {
            InitializeComponent();
            depRepository = new DepartmentRepository();
            UpdateGrid();
            DepartmentGrid.SelectionChanged += Select;
        }
        public void Select(object obj, EventArgs e)
        {
            DataGridView grid = (DataGridView)obj;
            Department department = depRepository.GetItem((int)grid.CurrentCell.Value);
            if (department != null)
            {
                Name.Text = department.Name;
                

            }
        }
        private void UpdateGrid()
        {
            var dep_list = (from dep in depRepository.GetList()
                            orderby dep.Name
                            select new {Id = dep.Id, DepartamentName = dep.Name }).AsQueryable();

            DepartmentGrid.DataSource = dep_list.ToList();
        }

        private void AddDepartament_Click(object sender, EventArgs e)
        {
            Department dep = new Department() { Name = Name.Text };
            depRepository.Create(dep);
            UpdateGrid();
            
        }

        private void DeleteDepartament_Click(object sender, EventArgs e)
        {
            depRepository.Delete((int)DepartmentGrid.CurrentCell.Value);
            UpdateGrid();
        }
    }
}
