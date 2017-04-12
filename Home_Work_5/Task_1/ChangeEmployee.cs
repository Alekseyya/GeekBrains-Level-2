using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    class ChangeEmployee : Change
    {
        TextBox EmpName = new TextBox();
        ListBox EmpEmployee = new ListBox();
        Button change = new Button();
        Form form1;
        List<Employee> listEmployee;
        public event EventHandler ShowEmployee;
        public ChangeEmployee(ComboBox cmb, List<Employee> listEmployee, List<Department> listDepartament)
        {
            form1 = new Form();
            form1.Text = $"Изменение сотрудников {cmb.SelectedItem} ";
            form1.Width = 500;
            this.listEmployee = listEmployee;
            FormParametrs();
            form1.Show();
            Update();
            EmpEmployee.SelectedIndexChanged += Form_ShowEmployee;
            change.Click += Button_Change;


        }

        private void Button_Change(object sender, EventArgs e)
        {
            var indexEmp = listEmployee.FindIndex(index => index.Name == (string)EmpEmployee.SelectedItem);
            listEmployee[indexEmp].Name = EmpName.Text;
            MessageBox.Show($"Сотрудник {EmpEmployee.SelectedItem} изменено на {EmpName.Text}");
            Update();
        }

        private void Form_ShowEmployee(object sender, EventArgs e)
        {
            ListBox comboxEmployee = (ListBox)sender;
            EmpName.Text = comboxEmployee.SelectedItem.ToString();
        }

        public override void FormParametrs()
        {
            //Отрисовка кнопочки button
            change.Parent = form1;
            change.Text = "Изменить";
            change.Top = 170;
            change.Left = 40;
            change.Show();

            //текст департамент textbox
            EmpName.Parent = form1;
            EmpName.Top = 100;
            EmpName.Left = 40;

            //сотрудники департамента listbox
            EmpEmployee.Parent = form1;
            EmpEmployee.Top = 100;
            EmpEmployee.Left = 170;

        }

        public override void Update()
        {
            EmpEmployee.Items.AddRange(listEmployee.Select(name => name.Name).ToArray());
        }


    }
}
