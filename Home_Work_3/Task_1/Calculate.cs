using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Calculate
    {
        private List<Book> list;
        public double averageCost { get; set; } 
        public double totalCost { get; set; }
        public List<Book> sortDec { get; set; }

        public Calculate(List<Book> list)
        {
            this.list = new List<Book>();
            this.list = list;
        }

        public List<Book> List { get { return this.list;} }

        public void SortDec()
        {
            List<Book> sortlist = list;
            sortlist.Sort();
            sortDec= sortlist;
        }

        public void GetAverageCost()
        {
            
            averageCost = (double)list.Where(book => book.CSharp == true).Sum(item => item.Price);
        }
        
        

        public void GetTotalCost()
        {
            
           double summCSharpbooks = (double)list.Where(book => book.CSharp == true).Sum(item => item.Price);
           int scharpCountBooks = (int)list.Where(book => book.CSharp == true).Count();
           totalCost= (double)summCSharpbooks / summCSharpbooks;
            
            
        }

        
    }
}
