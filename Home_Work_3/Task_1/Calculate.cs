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
        public double averageCost { get; private set; } 
        public double totalCost { get;  private set; }
        public List<Book> sortDec { get; private set; }

        public Calculate(List<Book> list)
        {
            this.list = new List<Book>();
            this.list = list;
        }

        //public List<Book> List { get { return this.list;} }

        public void SortDec() //переделать под убывание
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
           totalCost= (double)summCSharpbooks / scharpCountBooks;
            
            
        }
        public void Print()
        {
            Console.WriteLine("///////////////");
            foreach (var i in sortDec)
            {
                Console.WriteLine($"{i.Title} {i.Author} {i.Price} {i.CSharp}");
            }
            Console.WriteLine("///////////////");
            Console.WriteLine($"Общая стоимость всех книг по C# {averageCost}");
            Console.WriteLine($"Средняя стоимость всех книг по C# {totalCost}");
        }
        
    }
}
