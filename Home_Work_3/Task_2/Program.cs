using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ярчук Алексей

///Добавьте в пример Lesson3 обобщенный делегат
///
namespace Task_2
{
    public delegate void MethodContainer<T> (T value);

    
    class ClassCounter<T>
    {
        public event MethodContainer<T> onCount;
        public void Count()
        {
            
            for (int i = 0; i < 20; i++)
            {
                if(i==20)
                {
                    onCount(T);
                }

            }
        }
    }

    class Handler_1
    {
        public void Message(string value)
        {
            Console.WriteLine($"Оп хэй а ла лэй!! {value}");
        }
    }
    class Handler_2
    {
        public void Message(string value)
        {
            Console.WriteLine($"Вася танчит как поц {value}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassCounter<string> counter = new ClassCounter<string>();
            Handler_1 handler1 = new Handler_1();
            Handler_2 handler2 = new Handler_2();

            counter.onCount += handler1.Message;
            counter.onCount += handler2.Message;
            counter.Count();

        }

    }
}
