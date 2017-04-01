using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryForFigures
{
    public class Shape
    {
        public virtual double Square()
        {
            return 0;
        }
    }
    /// <summary>
    /// Труегольник
    /// </summary>
    public class Triangle :Shape
    {
        double side;
        double height;

        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        public double Height
        {
            get { return height; }

            set { height = value; }
        }
        /// <summary>
        /// Создает объект треугольник
        /// </summary>
        /// <param name="side">сторона</param>
        /// <param name="height">высота</param>
        public Triangle(double side, double height)
        {
            this.side = side;
            this.height = height;
        }
        public override double Square() =>  0.5 * Side * Height;
        
    }
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle: Shape
    {
        const double pi = 3.14;
        double radius;
        
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double Pi
        {
            get { return pi; }
        }
        /// <summary>
        /// Создание объекта круг.
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Square() => Pi * Radius;
        

        //Хотел сделать так чтобы этот класс считал по двум формулам, одна по радиусу, другам по диаметру
        // задумывал сделать через делегат вызов разных фукций в зависимости от того, по какой формуле
        // человек захоче посчитать. Но встала проблема в том, что метод переопередялеся, и в одном(этом классе)
        // не определишь методов с одинаковым количеством входных параметров и с одним именем.
        // Как сделовало бы правильно сделать, чтобы пользователь по своему выбору мог выбрать, формулу для подсчета площади?
        //public override double Square()
        //{
            
        //}



    }
    /// <summary>
    /// Квадрат
    /// </summary>
    public class Quadrate : Shape
    {
        int numbersOfsides;
        double sidecircle;

        public int NumbersOfsides
        {
            get { return numbersOfsides; }
            set { numbersOfsides = value; }
        }
        public double Sidecircle
        {
            get { return sidecircle; }
            set { sidecircle = value; }
        }
        /// <summary>
        /// Создание объекта квадрат
        /// </summary>
        /// <param name="numbersOfsides">Количество сторон квадрата</param>
        /// <param name="sidecircle">Длина одной строны</param>
        public Quadrate(int numbersOfsides, double sidecircle)
        {
            this.numbersOfsides = numbersOfsides;
            this.sidecircle = sidecircle;
        }
        public override double Square() => NumbersOfsides * Sidecircle;
        
    }

}
