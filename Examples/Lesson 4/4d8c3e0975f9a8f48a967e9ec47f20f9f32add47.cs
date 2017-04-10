using System;
using System.Collections.Generic;
using System.Linq;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Employee
{
    public int Id { get; set; }
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
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

        //select Name from employee
        //where DepartmentId in (select DepartmentId from department where dept.Name == "Management")
        var NameWithDept = (from dept in departments
                            where dept.Name == "Management"

                            let emp_select = from emp in employes
                                             where emp.DepartmentId == dept.Id
                                             select emp
                            select new
                            {
                                dept.Name,
                                emp_select
                            }).ToList();

        foreach (var dept in NameWithDept)
        {
            Console.WriteLine("Department - {0}", dept.Name);
            foreach (Employee emp in dept.emp_select)
                Console.WriteLine("\t Name \t{0}", emp.Name);
        }
        Console.WriteLine();

        //select * from (select * from Employees where Age<30) where Salary > 10000
        //------------------------------------------------------------------------------
        var query = (from emp in employes
                     where emp.Age < 30
                     let emp_select = emp.Salary > 10000
                     where emp_select == true                                          
                     select emp).ToList();

        foreach (var emp in query)
        {
            Console.WriteLine("\t Name \t{0},\t Age \t{1},\t Salary \t{2},", emp.Name, emp.Age, emp.Salary);
        }
        Console.WriteLine();
        //------------------------------------------------------------------------------
        var query1 = (from emp in employes
                      where emp.Age < 30
                      from emp1 in employes
                      where emp1.Id == emp.Id && emp1.Salary > 10000
                      select emp1).ToList();

            foreach (Employee emp in query1)
                Console.WriteLine("\t Name \t{0},\t Age \t{1},\t Salary \t{2},", emp.Name, emp.Age, emp.Salary);
        Console.WriteLine();
        //------------------------------------------------------------------------------
        var query2 = (from emp in employes
                      where emp.Age < 30
                      select emp into gEmp
                      where gEmp.Salary > 10000
                      select gEmp).ToList();
            foreach (Employee emp in query2)
                Console.WriteLine("\t Name \t{0},\t Age \t{1},\t Salary \t{2},", emp.Name, emp.Age, emp.Salary);

        }
    }
