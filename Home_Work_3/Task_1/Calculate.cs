using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Calculate : ICommand
    {
        private List<Book> list;
        public Calculate(List<Book> list)
        {
            this.list = new List<Book>();
            this.list = list;
        }

        public double AverageCost() => (double)list.Where(book => book.CSharp == true).Sum(item => item.Price);
        
        

        public double TotalCost()
        {
            double summCSharpbooks = AverageCost();
            int scharpCountBooks = (int)list.Where(book => book.CSharp == true).Count();
            return (double)summCSharpbooks / summCSharpbooks;
        }
    }
}
