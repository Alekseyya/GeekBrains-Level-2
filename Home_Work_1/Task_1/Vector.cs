using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    //Это класс можете не смотреть я трейнеровался
    class Vector
    {
        double x;
        double y;
        public Vector()
        {
            x = y = 0;
        }
        public Vector(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            Vector res = new Vector();
            res.x = v1.x - v2.x;
            res.y = v1.y - v1.y;
            return res;
        }
        // перегрузка унарного оператора -
        public static Vector operator -(Vector v1)
        {
            Vector res = new Vector();
            res.x = -1 * v1.x;
            res.y = -1 * v1.y;
            return res;
        }
        // свойство, которое возвращает закрытое поле X
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        // свойство, которое возвращает закрытое поле Y
        public double Y
        {
            get { return y; }
            set { y = value; }
        }


        //public static explicit operator Vector(double x)
        //{
        //    return new Vector(x, x);
        //}

        public static explicit operator double(Vector x)
        {
            return x.x;
        }
        public static implicit operator Vector(double x)
        {
            return new Vector(x, x);
        }

        //public static explicit operator Vector(double x, double y)
        //{
        //    return new Vector(x, y);
        //}
        public virtual void Method()
        {
            Console.WriteLine($"Base method1");
        }
        public virtual void Method1()
        {
            Console.WriteLine($"Base mathod2");
        }
        

    }

    class MyClass: Vector
    {
        public Vector pos;
        double width, height;
        public MyClass()
        {

        }
        public MyClass(double _wigth, double _height,Vector v)
        {
            this.width = _wigth;
            this.height = _height;
            pos = v; //new Vector(10,20)
        }
        //public override void Method()
        //{
        //    Console.WriteLine($"Deriver method1");
        //}
        public override void Method()
        {
            Console.WriteLine("Deliver method1");
        }
        public new void Method1()
        {
            Console.WriteLine($"Deriver method2");
        }

    }
}
