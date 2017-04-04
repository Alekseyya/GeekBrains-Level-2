using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Library : IEnumerable<Book>, ILibrary
    {
        private List<Book> library;
        public delegate void ProcessBookDelegate(Book book);

        public Library()
        {
            this.library = new List<Book>();

        }

        public void AddBook()
        {
            
        }
       

        public IEnumerator<Book> GetEnumerator() => library.GetEnumerator();

        public void ProcessBook(ProcessBookDelegate processBookDelegate)
        {
            
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        
    }
}
