using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
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

            // создаем объект SoapFormatter
            SoapFormatter formatter = new SoapFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            //using (FileStream fs = new FileStream("people.soap", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, employes.ToArray());

            //    Console.WriteLine("Объект сериализован");
            //}

            using (FileStream fs = new FileStream("people.soap", FileMode.OpenOrCreate))
            {
                Employee[] newEmployee = (Employee[])formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                var t = newEmployee;
            }


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
            ChangeEmployee changeEmp = new ChangeEmployee((ComboBox) sender, listEmployee, listDepartament);
            changeEmp.GetForm.FormClosed += Form1_Closed;

        }
        private void CBDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDepartment changeDep = new ChangeDepartment((ComboBox)sender, listEmployee, listDepartament);
            changeDep.GetForm.FormClosed += Form1_Closed;


        }

        private void Form1_Closed(object sender, System.EventArgs e)
        {
            MainForm_Update();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEmployee addEmp = new AddEmployee(listDepartament, listEmployee);
            addEmp.GetForm.FormClosed += Form1_Closed;

        }

        private void AddDepbutton_Click(object sender, EventArgs e)
        {
            AddDepartament addDep = new AddDepartament(listDepartament, listEmployee);
            addDep.GetForm.FormClosed += Form1_Closed;

        }
    }
}
