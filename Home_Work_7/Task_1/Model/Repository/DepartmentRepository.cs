using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Model.Interface;

namespace Task_1.Model.Repository
{
    public class DepartmentRepository : IRepository<Department>
    {
        private Office context;
        public DepartmentRepository()
        {
            this.context = new Office();
            

        }
        public void Create(Department item)
        {
            context.Departments.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Department dep = context.Departments.Find(id);
            if (dep != null)
                context.Departments.Remove(dep);
            context.SaveChanges();
        }

        public Department GetItem(int id)
        {
            return context.Departments.Find(id);
        }

        public IList<Department> GetList()
        {
            return context.Departments.ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Department item)
        {
            Department dep = context.Departments.Find(item.Id);
            dep.Id = (item.Id != 0) ? item.Id : dep.Id;
            dep.Name = (item.Name != null) ? item.Name : dep.Name;
            context.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    context.Dispose(); // TODO: освободить управляемое состояние (управляемые объекты).
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~DepartmentRepository() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
