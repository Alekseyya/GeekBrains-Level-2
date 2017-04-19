using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Model.Interface;


namespace Task_1.Model.Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private Office context;

        
        public EmployeeRepository()
        {
            
            this.context = new Office();
        }

        public IList<Employee> GetList()
        {
            return context.Employees.ToList();
        }

        public void Create(Employee item)
        {
            context.Employees.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Employee emp = context.Employees.Find(id);
            if (emp != null)
                context.Employees.Remove(emp);
            context.SaveChanges();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Employee GetItem(int id)
        {
            return context.Employees.Find(id);
        }
        
        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Employee item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
