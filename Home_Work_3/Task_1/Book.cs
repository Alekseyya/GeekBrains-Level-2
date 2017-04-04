using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    //PoCo класс
    class Book
    {
        private string Title; // Название.
        private string Author; // Автор.
        private decimal Price; // Цена.
        private bool CSharp; // Книга о C#

        public delegate void ProcessBookDelegate(Book book);

        public Book(string Title, string Autor, decimal Price, bool CSharp) //Писать в конструкторе тру/фолс на кажлой книге фигня(передалать)
        {
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
            this.CSharp = CSharp;
        }
    }
}
