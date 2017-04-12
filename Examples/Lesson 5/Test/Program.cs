using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class A
    {
        public int i;
        public Func<int> Func()
        {
            return () => i + 5;
        }
    }
    class Prog
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.i = 1;
            Func<int> f = a.Func();
            a.i = 10;

            Console.WriteLine(f());
            
        }
    }

}
