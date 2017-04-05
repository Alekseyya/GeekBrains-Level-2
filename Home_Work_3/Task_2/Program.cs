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
    
    public class MyEventArgs : EventArgs
    {
        private string msg;
        private int phone;

        public MyEventArgs(string messageData, int phone)
        {
            msg = messageData;
            this.phone = phone;
        }
        public string Message
        {
            get { return msg; }
            set { msg = value; }
        }
        public int MyPhone { get { return phone; } set { phone = value; } }
    }

    public class ClassCounter
    {
        
        public event EventHandler<MyEventArgs> onCount;

        //Не получилось, не знаю как вызвать данное событие
        public void DemoEvent(string val, int phone)
        {
            
            EventHandler<MyEventArgs> temp = onCount;
            if (temp != null)
                temp(this, new MyEventArgs(val, phone));
        }
    }

    class Handler_1
    {
        public void Message(object src, MyEventArgs mea)
        {
            Console.WriteLine($"Оп хэй а ла лэй!! {mea.Message} {mea.MyPhone}");
        }
    }
    class Handler_2
    {
        public void Message(object src, MyEventArgs mea)
        {
            Console.WriteLine($"Вася танчит как поц {mea.Message} {mea.MyPhone}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassCounter counter = new ClassCounter();
            Handler_1 handler1 = new Handler_1();
            Handler_2 handker2 = new Handler_2();
            counter.onCount += new EventHandler<MyEventArgs>(handler1.Message);
            counter.onCount += new EventHandler<MyEventArgs>(handker2.Message);

            counter.DemoEvent(" ссссу ууу  ВАААААСЯЯ!! ШО ты РОРБИШЬ!!!!!!!", 228);
            Console.ReadKey();
        }

    }
}
