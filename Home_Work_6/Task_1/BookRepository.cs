using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class BookRepository : GenericRepo<Book>
    {
        List<Book> list;
        public BookRepository()
        {
            this.list = new List<Book>();
        }
       
        
    }
}
