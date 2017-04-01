using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibraryForFigures;

//Ярчук Алексей

/// <summary>
/// Создайте консольное приложение, в котором будет реализована возможность расчета площади геометрических фигур.
/// У нас есть класс Shape и производные от него классы: Triangle, Circle, Square. 
/// Наша задача через консоль запрашивать у пользователя, площадь какой фигуры он хочет рассчитать,
/// необходимые параметры фигуры, и далее, для этой фигуры, вызывать переопределенный виртуальный метод Square,
/// который будет рассчитывать площадь фигуры и выдавать результат на консоль.
/// </summary>

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
        }

        static void Print()
        {
            Shape circle = new Circle(15);
            Shape triangle = new Triangle(4, 15);
            Shape quadre = new Quadrate(5, 15);
            Console.WriteLine($"Прощадь шара {circle.Square()}");
            Console.WriteLine($"Прощадь треугольника {triangle.Square()}");
            Console.WriteLine($"Прощадь квадрата {quadre.Square()}");

            Console.ReadKey();
        }
    }
}
