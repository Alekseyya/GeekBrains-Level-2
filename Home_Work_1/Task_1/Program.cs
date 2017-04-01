using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            TesDelegate ts = new TesDelegate();
            ts.showmessage += delegate { i++; Console.WriteLine($"{i++}"); }; //вызываемый код образается во время выполнени события

            Console.WriteLine($"{i}");

            System.Type type = typeof(int);
            Console.WriteLine(type);

            Console.ReadKey();
            
        }


        
        static void Print()
        {
            Console.Write("Введите целую часть первого комплексного числа: ");
            double r1 = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double i1 = double.Parse(Console.ReadLine());
            Console.Write("Введите целую часть второго комплексного числа: ");
            double r2 = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double i2 = double.Parse(Console.ReadLine());
            Console.Clear();
            Complex c1 = new Complex(r1,i1);
            Complex c2 = new Complex(r2,i2);
            
            Console.WriteLine("Введенные комплексные числа: ");
            Console.WriteLine(c1.Print());
            Console.WriteLine(c2.Print());

            Console.WriteLine("\nДля продолжения нажмите [Enter]");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Сложение комплексных чисел:       {c1.Im + c2.Im} + {c1.Re +c2.Re}i");
            Console.WriteLine($"Вычитание комплексных чисел:      {c1.Im - c2.Im} - {c1.Im - c2.Im}i");
            Console.WriteLine("\nДля выхода из программы нажмите [Enter]");
            Console.ReadLine();
        }
        /// <summary>
        /// Эта функция для трейнировки, можно не смотреть
        /// </summary>
        static void Test()
        {
            MyClass my = new MyClass(10, 20, new Vector(1, 1));
            my.pos.Method();
            my.pos.Method1();
            my.Method();
            my.Method1();
            Console.WriteLine("---------------------");
            Vector vc = new Vector();
            MyClass my1 = new MyClass();

            vc.Method();
            my1.Method();
            //Демонстрация полиморфима
            Vector vcr = new MyClass();
            //при вызове будет вызываться переопределенный метод
            vcr.Method();
            Console.WriteLine("//////////////////////");
            //is проверяет совместимость обекста с заданным типом
            if (vc is Vector)
            {
                Console.WriteLine("Соответвует Vector");
            }
            else { Console.WriteLine("Не соотвествует Vector"); }
            if (my1 is MyClass)
            {
                Console.WriteLine("Соответвует Myclass");
            }
            if (vcr is Vector)
            {
                Console.WriteLine("Соответсвует Vector ");
            }
            else { Console.WriteLine("Не соответствует Vector"); }
            Console.WriteLine("\\\\\\\\\\\\\\\\\\");
            //as используется для выполнения преобразование типов между совместными ссылочными типами и тип допускающий null
            MyClass my3 = new MyClass(10, 20, new Vector(10, 20));
            Vector vctr = my as Vector;
            //вместо исключения будет выдано null
            if (vctr != null)
            {
                Console.WriteLine("Преобразование Myclass в Vector выполнено");
            }
            else
            {
                Console.WriteLine("Не выполнено преобразование");
            }
            Console.ReadKey();
        }

        static void Test1()
        {
            //Print();
            TesDelegate ts = new TesDelegate();
            //Program pr = new Program();
            //ts.showmess = ts.Message;
            //ts.Message("sdf");
            ////Вызываемый код также может вызывать делегат
            //ts.showmess.Invoke("Hello");

            ts.showmessage += new TesDelegate.ShowMessage(ts.Message);



            ts.showmessage1 += ts.Message1;
            ts.Acces(1);
            ts.showmessage -= ts.Message;
            ts.Acces(4);
        }
        
        
    }
}
