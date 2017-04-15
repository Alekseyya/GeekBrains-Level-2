using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public abstract class GenericRepo<T> :IEnumerable<T>
    {
        private List <T> repo;
        public GenericRepo()
        {
            this.repo = new List<T>();
        }
        //итератор
        public T this[int index]
        {
            get { return repo[index]; }
            set { repo.Insert(index, value); }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return repo.GetEnumerator();
        }
        System.Collections.IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        //получить элемент
        //public T GetItem(int id)
        //{

        //}

        //Добавить элемент
        public void Create(T item)
        {
            repo.Add(item);
        }

        //Удалить элемент
        public void Delete(T item)
        {
            repo.Remove(item);
        }

        //Обновить элемент
        public void Update(T item)
        {
            var find = repo.FirstOrDefault(id => id.GetHashCode() == item.GetHashCode());
            if (find != null)
            {
                Delete(find);
                Create(item);
            }
            
        }

        
    }
}
