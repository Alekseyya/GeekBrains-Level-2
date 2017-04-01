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
            Wolf wlf = new Wolf("Petya");
            Pig pig = new Pig("Grisha");
            Squirrel sq = new Squirrel("Sergey");

            Zoo zoo = new Zoo();
            zoo.Add(wlf);
            zoo.Add(pig);
            zoo.Add(sq);
            var t = 0; 

        }
    }
}
