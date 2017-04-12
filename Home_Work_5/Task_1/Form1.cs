using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        private List<Employee> listEmployee;
        private List<Department> listDepartament;

        public Form1()
        {
            InitializeComponent();

            var employes = new List<Employee>
            {
                new Employee { Id = 1, Age = 22, DepartmentId = 1, Name = "Vasya", Salary = 3000 },
                new Employee { Id = 2, Age = 25, DepartmentId = 1, Name = "Petya", Salary = 6000 },
                new Employee { Id = 3, Age = 23, DepartmentId = 1, Name = "Kolya", Salary = 8000 },
                new Employee { Id = 4, Age = 28, DepartmentId = 1, Name = "Michail", Salary = 11000 },
                new Employee { Id = 5, Age = 35, DepartmentId = 2, Name = "Kostya", Salary = 5000 },
                new Employee { Id = 6, Age = 33, DepartmentId = 1, Name = "Andrey", Salary = 7000 },
                new Employee { Id = 7, Age = 21, DepartmentId = 1, Name = "Oleg", Salary = 12000 },
                new Employee { Id = 8, Age = 20, DepartmentId = 1, Name = "Pavel", Salary = 11000 },
                new Employee { Id = 9, Age = 36, DepartmentId = 2, Name = "Maksim", Salary = 10000 },
                new Employee { Id = 10, Age = 45, DepartmentId = 2, Name = "Arseniy", Salary = 20000 },
                new Employee { Id = 11, Age = 41, DepartmentId = 3, Name = "Nekto", Salary = 99999999 }
            };

            var departments = new List<Department>
            {
                new Department { Id = 1, Name = "IT" },
                new Department { Id = 2, Name = "Management" }
            };

            listDepartament = departments;
            listEmployee = employes;

            //Событие выбора департамента
            CBDepartament.SelectedIndexChanged += CBDepartament_SelectedIndexChanged;
            CBEmployee.SelectedIndexChanged += CBEmployee_SelectedIndexChanged;

            MainForm_Update();


        }

        private void MainForm_Update()
        {
            CBDepartament.Items.Clear();
            CBEmployee.Items.Clear();
            CBDepartament.Items.AddRange(listDepartament.Select(name => name.Name).ToArray());
            CBEmployee.Items.AddRange(listEmployee.Select(name => name.Name).ToArray());
            
            
        }

        
        private void CBEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            TextBox EmpName = new TextBox();
            ListBox EmpEmployee = new ListBox();
            Button change = new Button();

           
            //Настройки формы
            Form form1 = new Form();
            form1.Text = $"Изменение сотрудников {cmb.SelectedItem} ";
            form1.Width = 500;
            
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
            //var t = listEmployee.Where(id => id.Id == listDepartament.Find(name => name.Name == cmb.SelectedItem).Id).Select(name => name.Name).ToList();
            EmpEmployee.Items.AddRange(listEmployee.Select(name => name.Name).ToArray());
            form1.Show();

            EmpEmployee.SelectedIndexChanged += (s, ev) =>
            {
                ListBox comboxEmployee = (ListBox)s;
                EmpName.Text = comboxEmployee.SelectedItem.ToString();
            };

            //изменение
            change.Click += (send, ee) =>
            {
                var indexEmp = listEmployee.FindIndex(index => index.Name == (string)EmpEmployee.SelectedItem);
                listEmployee[indexEmp].Name = EmpName.Text;
                MessageBox.Show($"Сотрудник {EmpEmployee.SelectedItem} изменено на {EmpName.Text}");

            };
            
            form1.FormClosed += Form1_Closed;


        }
        private void CBDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            TextBox DepName = new TextBox();
            ListBox DepEmployee = new ListBox();
            Button change = new Button();
            var indexDep = listDepartament.FindIndex(index => index.Name == (string)cmb.SelectedItem);

            //Настройки формы
            Form form1 = new Form();
            form1.Text = $"Изменение департамента {cmb.SelectedItem} ";
            form1.Width = 500;

            //Отрисовка кнопочки
            change.Parent = form1;
            change.Text = "Изменить";
            change.Top = 170;
            change.Left = 40;
            change.Show();

            //текст департамент
            DepName.Name = "DepartamentName";
            DepName.Parent = form1;
            DepName.Top = 100;
            DepName.Left = 40;
            DepName.Text = listDepartament[indexDep].Name.ToString();

            

            //сотрудники департамента
            DepEmployee.Name = "DepartametEmployee";
            DepEmployee.Parent = form1;
            DepEmployee.Top = 100;
            DepEmployee.Left = 170;
            //var t = listEmployee.Where(id => id.Id == listDepartament.Find(name => name.Name == cmb.SelectedItem).Id).Select(name => name.Name).ToList();
            DepEmployee.Items.AddRange(listEmployee.Where(id => id.Id== listDepartament.Find(name => name.Name == (string)cmb.SelectedItem).Id).Select(name => name.Name).ToArray());
            form1.Show();

            //изменение
            change.Click += (send, ee) =>
            {
                listDepartament[indexDep].Name = DepName.Text;
                MessageBox.Show($"Департамент {cmb.SelectedItem} изменено на {DepName.Text}");
                
            };

            form1.FormClosed += Form1_Closed;


        }

        private void Form1_Closed(object sender, System.EventArgs e)
        {
            MainForm_Update();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //для добавления сотруников
            TextBox ageTextbox = new TextBox();
            ComboBox employeeCombobox = new ComboBox();
            TextBox nameTextbox = new TextBox();
            TextBox salaryTexbox = new TextBox();
            Label ageText = new Label();
            ListBox EmpEmployee = new ListBox();
            Button change = new Button();

            //Настройки формы
            Form form1 = new Form();
            form1.Text = $"Добавление сотрудников";
            form1.Width = 500;

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

            EmpEmployee.Items.AddRange(listEmployee.Select(name => name.Name).ToArray());
            employeeCombobox.Items.AddRange(listDepartament.Select(nameDep => nameDep.Name).ToArray());

            change.Show();
            form1.Show();

            change.Click += (s, ev) =>
            {
                var lastId = listEmployee.Last().Id;
                //по дефолту первый берем
                
                try
                {
                    listEmployee.Add(new Employee
                    {
                        Id = lastId++,
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
                    EmpEmployee.Items.AddRange(listEmployee.Select(name => name.Name).ToArray());
                    ageTextbox.Clear();
                    nameTextbox.Clear();
                    salaryTexbox.Clear();
                }

               
            };
            

            form1.FormClosed += Form1_Closed;

        }

        private void AddDepbutton_Click(object sender, EventArgs e)
        {
            ListBox listDep = new ListBox();
            TextBox nameDep = new TextBox();
            Button addDep = new Button();


            Form form1 = new Form();
            form1.Text = "Добавить новый департамент";

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

            listDep.Items.AddRange(listDepartament.Select(name => name.Name).ToArray());
            form1.Show();

            addDep.Click += (s, ev) =>
            {
                if(nameDep.Text!= "")
                {
                    listDepartament.Add(new Department { Id = listEmployee.Last().Id++, Name = nameDep.Text } );
                }
                listDep.Items.Clear();
                listDep.Items.AddRange(listDepartament.Select(name => name.Name).ToArray());
            };

            form1.FormClosed += Form1_Closed;

        }
    }
}
