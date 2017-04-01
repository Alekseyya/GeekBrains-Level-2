using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ярчук Алексей

/// <summary>
/// Создайте класс Complex, который будет реализовывать функции для работы с
/// комплексными числами.Предусмотрите переопределение операторов: +, - для этого класса.
/// Продемонстрируйте работу класса в консольном приложении
/// (ввод комплексных чисел и вывод результата).
/// </summary>



namespace Task_1
{
    class Complex
    {
        double im;
        double re;
        /// <summary>
        /// Возврат и указание первого действительного  числа
        /// </summary>
        public double Im
        {
            get { return this.im; }
            set { im = value; }//поставить ограничение throw
        }
        /// <summary>
        /// Возврат и указание второго действительного числа
        /// </summary>
        public double Re
        {
            get { return this.re; }
            set { re = value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="im">Первое действительное число</param>
        /// <param name="re">Второе дейсвительное число</param>
        public Complex(double im, double re)
        {
            this.im = im;
            this.re = re;

        }

        public Complex()
        {
            im = re = 0;
        }
        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="a">Первое комплексное число</param>
        /// <param name="b">Второе комплексное число</param>
        /// <returns></returns>
        public static Complex operator + (Complex a, Complex b)
        {
            Complex res = new Complex();
            res.Im = a.Im + b.Im;
            res.Re = a.Re + b.Re;
            return res;
        }
        /// <summary>
        /// Разность комплексных чисел
        /// </summary>
        /// <param name="a">Первое комплексное число</param>
        /// <param name="b">Второе комплексное число</param>
        /// <returns></returns>
        public static Complex operator - (Complex a, Complex b)
        {
            Complex res = new Complex();
            res.Im = a.Im - b.Im;
            res.Re = a.Re - b.Re;
            return res;
        }

        public string Print()
        {
            return Re + "+" + Im + "i";
        }
    }
}
