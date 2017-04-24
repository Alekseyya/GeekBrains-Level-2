using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFWebService.Controllers;
using WCFWebService.Model;

namespace WCFWebService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service.svc или Service.svc.cs в обозревателе решений и начните отладку.
    public class Service : IService
    {
        DepartmentController depController;
        EmployeeConroller empController;
        public Service()
        {
            empController = new EmployeeConroller();
            depController = new DepartmentController();
        }

        public List<Employee> GetListEmp()
        {
            List<Employee> empList = new List<Employee>();
            var emp_list = (from emp in empController.GetList()
                                     orderby emp.Name
                                     select new { Id = emp.Id, EmployeeName = emp.Name, Age = emp.Age, Salary = emp.Salary }).AsQueryable();
            foreach(var emp in emp_list)
            {
                empList.Add(new Employee
                {
                    Id = emp.Id,
                    Age = emp.Age,
                    Name = emp.EmployeeName,
                    Salary = emp.Salary
                });
            }
            return empList;
        }
        public List<Department> GetListDep()
        {
            List<Department> listDep = new List<Department>();
            var dep_list = (from dep in depController.GetList()
                            orderby dep.Name
                            select new { Id = dep.Id, DepartamentName = dep.Name }).AsQueryable();
            foreach(var dep in dep_list)
            {
                listDep.Add(new Department { Id = dep.Id, Name = dep.DepartamentName });
            }
            return listDep;
        }

        public Employee GetItemEmp(int id)
        {
            return empController.GetItem(id);
        }

        public void CreateEmp(Employee item)
        {
            empController.Create(item);
        }

        public void DeleteEmp(int id)
        {
            empController.Delete(id);
        }

        public void UpdateEmp(Employee item)
        {
            empController.Update(item);
        }
    }
}
