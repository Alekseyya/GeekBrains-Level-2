using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    class ChangeDepartment : Change
    {
        TextBox DepName = new TextBox();
        ListBox DepEmployee = new ListBox();
        Button change = new Button();
        ComboBox cmb;
        Form form1;

        List<Employee> listEmployee;
        List<Department> listDepartament;

        int indexDep { get; set; }

        public ChangeDepartment(ComboBox cmb, List<Employee> listEmployee, List<Department> listDepartament)
        {
            this.listDepartament = listDepartament;
            this.listEmployee = listEmployee;
            this.indexDep = listDepartament.FindIndex(index => index.Name == (string)cmb.SelectedItem);

            this.cmb = cmb;

            //Настройки формы
            form1 = new Form();
            form1.Text = $"Изменение департамента {cmb.SelectedItem} ";
            form1.Width = 500;
            
            FormParametrs();
            form1.Show();
            //Обновление списка департамента
            Update();

            change.Click += Button_Change;
            


        }

        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Change(object sender, EventArgs e)
        {
            listDepartament[indexDep].Name = DepName.Text;
            MessageBox.Show($"Департамент {cmb.SelectedItem} изменено на {DepName.Text}");
            Update();
        }

        public override void FormParametrs()
        {
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
        }

        public override void Update()
        {
            DepEmployee.Items.AddRange(listEmployee.Where(id => id.Id == listDepartament.Find(name => name.Name == (string)cmb.SelectedItem).Id).Select(name => name.Name).ToArray());
        }
    }
}
