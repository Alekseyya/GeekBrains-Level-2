using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    //PoCo класс
    public class Book : IComparable<Book>
    {
        private string title; // Название.
        private string author; // Автор.
        private decimal price; // Цена.
        private bool cSharp; // Книга о C#

        

        public Book(string Title, string Autor, decimal Price, bool CSharp) //Писать в конструкторе тру/фолс на кажлой книге фигня(передалать)
        {
            this.title = Title;
            this.author = Author;
            this.price = Price;
            this.cSharp = CSharp;
        }
        public string Author { get { return this.Author; } }
        public decimal Price { get { return this.price; } }
        public bool CSharp { get { return this.cSharp; } }

        public int CompareTo(Book other)
        {
            Book p = other as Book;
            if (p != null)
                return this.price.CompareTo(p.price);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
