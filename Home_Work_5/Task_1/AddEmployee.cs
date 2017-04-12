using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    class AddEmployee : Add
    {
        TextBox ageTextbox = new TextBox();
        ComboBox employeeCombobox = new ComboBox();
        TextBox nameTextbox = new TextBox();
        TextBox salaryTexbox = new TextBox();
        ListBox EmpEmployee = new ListBox();
        Button change = new Button();
        Form form1;


        List<Department> listDepartament;
        List<Employee> listEmployee;

        public AddEmployee(List<Department> listDepartament, List<Employee> listEmployee)
        {
            this.listEmployee = listEmployee;
            this.listDepartament = listDepartament;

            form1 = new Form();
            form1.Text = $"Добавление сотрудников";
            form1.Width = 500;
            FormParamets();
            form1.Show();
            Update();

            change.Click += AddEssence;
        }
        public override void AddEssence(object sender, EventArgs e)
        {
            
            try
            {
                listEmployee.Add(new Employee
                {
                    Id = listEmployee.Last().Id++,
                    Age = Convert.ToInt32(ageTextbox.Text),
                    DepartmentId = listDepartament.Find(name => name.Name == (string)employeeCombobox.SelectedItem).Id,
                    Name = nameTextbox.Text,
                    Salary = Convert.ToInt32(salaryTexbox.Text)

                });
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Что-то введено неправильно! {ex.Message}");
            }
            finally
            {
                Update();
                ClearComponents();
            }
        }
        public new void ClearComponents()
        {
            ageTextbox.Clear();
            nameTextbox.Clear();
            salaryTexbox.Clear();
        }

        public override void FormParamets()
        {
            //отрисовка для добавления сотрудников
            change.Parent = form1;
            change.Text = "Изменить";
            change.Top = 170;
            change.Left = 40;
            change.Show();

            //сотрудники департамента listbox
            EmpEmployee.Parent = form1;
            EmpEmployee.Top = 100;
            EmpEmployee.Left = 170;


            ageTextbox.Parent = form1;
            ageTextbox.Top = 100;
            ageTextbox.Left = 300;

            //для выбора депортамента
            employeeCombobox.Parent = form1;
            employeeCombobox.Top = 160;
            employeeCombobox.Left = 300;

            nameTextbox.Parent = form1;
            nameTextbox.Top = 190;
            nameTextbox.Left = 300;

            salaryTexbox.Parent = form1;
            salaryTexbox.Top = 220;
            salaryTexbox.Left = 300;


            change.Show();
        }

        public override void Update()
        {
            EmpEmployee.Items.AddRange(listEmployee.Select(name => name.Name).ToArray());
            employeeCombobox.Items.AddRange(listDepartament.Select(nameDep => nameDep.Name).ToArray());
        }
    }
}
