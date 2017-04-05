using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public delegate void ProcessBookDelegate();

    public class Library : IEnumerable<Book>, ILibrary
    {
        private List<Book> library;
        

        public Library()
        {
            
            this.library = new List<Book>();
            //Calculate calculate = new Calculate(library);
        }

        public List<Book> LibraryList { get{ return this.library; } }
        public void Add<T>(params T[] objct)
        {
            foreach(var i in objct)
            {
                Book book = i as Book;
                if (book != null)
                {
                    this.library.Add(book);
                }
                else
                {
                    throw new Exception("Невозможно включить данный бъект в список Books");
                }
            }
            
            
        }
       

        public IEnumerator<Book> GetEnumerator() => library.GetEnumerator();

        public void ProcessBook(ProcessBookDelegate processBookDelegate)
        {
            processBookDelegate();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        
    }
}
