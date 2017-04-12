using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var weather = new net.webservicex.www.GlobalWeather();
            var stri = weather.GetWeather("Moscow", "Russia");
            Console.WriteLine($"{stri}");
            Console.ReadKey();
        }
    }
}
