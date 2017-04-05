using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ярчук Алексей

/// <summary>
/// Разработать класс описывающий библиотеку, Bookstore. Класс должен поддерживать возможность добавлять книги в библиотеку,
/// метод AddBook, и обрабатывать книги, метод ProcessBooks(ProcessBookDelegate processBook).
/// Книги в библиотеке имеют следующие атрибуты:
/// public string Title; // Название.
/// public string Author; // Автор.
/// public decimal Price; // Цена.
/// public bool CSharp; // Книга о C#
/// Используя делегат public delegate void ProcessBookDelegate(Book book)
/// 1) распечатать названия всех книг о С# отсортировав их по убыванию цены в консоли
/// 2) вычислить и отобразить общую стоимость всех книг о С# в консоли
/// 3) вычислить и отобразить среднюю стоимость книг о С# в консоли.
/// Расчет общей и средней стоимости реализовать в отдельном классе.
/// Интерфейс для реализации сортировки IComparable.
/// </summary>


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            Calculate cal = new Calculate(lib.LibraryList);

            lib.Add(new Book("Война и мир", "Булгаков", 1278, false), new Book("C# 7", "Я", 4000, true)); //дописать пару книг

            ProcessBookDelegate process;
            ProcessBookDelegate sortlist = cal.SortDec;
            ProcessBookDelegate averageCost = cal.GetAverageCost;
            ProcessBookDelegate totalCost = cal.GetTotalCost;

            process = sortlist;
            process += averageCost;
            process += totalCost;


            lib.ProcessBook(process);
            
            
        }
    }
}
