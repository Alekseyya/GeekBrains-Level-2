using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    class AddDepartament : Add
    {
        ListBox listDep = new ListBox();
        TextBox nameDep = new TextBox();
        Button addDep = new Button();
        Form form1;

        List<Department> listDepartament;
        List<Employee> listEmployee;

        public event EventHandler Clear;

        public AddDepartament(List<Department> listDepartament, List<Employee> listEmployee)
        {
            this.listEmployee = listEmployee;
            this.listDepartament = listDepartament;
            form1 = new Form();
            form1.Text = "Добавить новый департамент";
            FormParamets();
            form1.Show();
            Update();

            addDep.Click += AddEssence;
            Clear += ClearComponents;
        }
        public Form GetForm { get { return form1; } }
        public override void AddEssence(object sender, EventArgs e)
        {
            if (nameDep.Text != "")
            {
                listDepartament.Add(new Department { Id = listEmployee.Last().Id++, Name = nameDep.Text });
            }
            Clear(listDep, new EventArgs());
            Update();
        }

        public override void Update()
        {
            listDep.Items.AddRange(listDepartament.Select(name => name.Name).ToArray());
        }
        public override void FormParamets()
        {
            listDep.Parent = form1;
            listDep.Top = 90;
            listDep.Left = 100;

            nameDep.Parent = form1;
            nameDep.Top = 50;
            nameDep.Left = 100;

            addDep.Parent = form1;
            addDep.Text = "Добавить";
            addDep.Top = 120;
            addDep.Left = 20;
            addDep.Show();
        }
        public override void ClearComponents(object sender, EventArgs e)
        {
            listDep.Items.Clear();
        }
    }
}
