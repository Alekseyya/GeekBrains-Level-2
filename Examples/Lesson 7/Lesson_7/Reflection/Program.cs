using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    using System;
    using System.Reflection;

    class Sample
    {
        private string _x = "No change me!";
        public override string ToString()
        {
            return _x;
        }
    }
    class Program
    {
        static void Main()
        {
            var sample = new Sample();
            typeof(Sample).GetField("_x", BindingFlags.NonPublic | BindingFlags.Instance)
                   .SetValue(sample, "I change you...");
            Console.Write(sample);
            Console.ReadKey();
        }
    }
}
