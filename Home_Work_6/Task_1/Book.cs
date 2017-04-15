using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    //класс контейнер
    public class Book :IEquatable<Book>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }


        public override int GetHashCode()
        {
            return Id;
        }
        public bool Equals(Book other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }
    }
}
