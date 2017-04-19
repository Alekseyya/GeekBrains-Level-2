using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Model
{
    public class OfficeContextIntializer
    {
        public void Seed(Office context)
        {
            
            context.Departments.AddRange(new List<Department>
            {
                new Department { Id = 1, Name = "IT" },
                new Department { Id = 2, Name = "Management" },
                new Department { Id = 3, Name = "HR" }

            });
            context.SaveChanges();

            
            context.Employees.AddRange(new List<Employee>
            {
                new Employee { Id = 1, Age = 22, DepartmentId = context.Departments.Where(x => x.Name == "IT").FirstOrDefault().Id, Name = "Vasya", Salary = 3000 },
                new Employee { Id = 2, Age = 25, DepartmentId = context.Departments.Where(x => x.Name == "IT").FirstOrDefault().Id, Name = "Petya", Salary = 6000 },
                new Employee { Id = 3, Age = 23, DepartmentId = context.Departments.Where(x => x.Name == "IT").FirstOrDefault().Id, Name = "Kolya", Salary = 8000 },
                new Employee { Id = 4, Age = 28, DepartmentId = context.Departments.Where(x => x.Name == "IT").FirstOrDefault().Id, Name = "Michail", Salary = 11000 },
                new Employee { Id = 5, Age = 35, DepartmentId = context.Departments.Where(x => x.Name == "Management").FirstOrDefault().Id, Name = "Kostya", Salary = 5000 },
                new Employee { Id = 6, Age = 33, DepartmentId = context.Departments.Where(x => x.Name == "IT").FirstOrDefault().Id, Name = "Andrey", Salary = 7000 },
                new Employee { Id = 7, Age = 21, DepartmentId = context.Departments.Where(x => x.Name == "IT").FirstOrDefault().Id, Name = "Oleg", Salary = 12000 },
                new Employee { Id = 8, Age = 20, DepartmentId = context.Departments.Where(x => x.Name == "IT").FirstOrDefault().Id, Name = "Pavel", Salary = 11000 },
                new Employee { Id = 9, Age = 36, DepartmentId = context.Departments.Where(x => x.Name == "Management").FirstOrDefault().Id, Name = "Maksim", Salary = 10000 },
                new Employee { Id = 10, Age = 45, DepartmentId = context.Departments.Where(x => x.Name == "Management").FirstOrDefault().Id, Name = "Arseniy", Salary = 20000 },
                new Employee { Id = 11, Age = 41, DepartmentId = context.Departments.Where(x => x.Name == "HR").FirstOrDefault().Id, Name = "Nekto", Salary = 99999999 }

            });

            context.SaveChanges();

            //context.Songs.AddRange(new List<Song>
            //{
            //    new Song { Name = "Песня 1", Album = context.Albums.Where(x => x.Id == 1).FirstOrDefault()},
            //    new Song { Name = "Песня 2", Album = context.Albums.Where(x => x.Id == 2).FirstOrDefault()},
            //    new Song { Name = "Песня 3", Album = context.Albums.Where(x => x.Id == 3).FirstOrDefault()}
            //});

            //context.SaveChanges();

        }
    }
}
