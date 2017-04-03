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

            Start();
            Console.ReadKey();
        }
        static void Start()
        {
            FixedWorker worker1 = new FixedWorker("Malinoz", "Sergey");
            TimerWorker timerworker1 = new TimerWorker("Malahov", "Boris", 700);

            Office office1 = new Office();
            office1.Add(timerworker1);
            office1.Add(worker1);


            office1.workers.Sort(office1);

            foreach (var worker in office1)
            {
                Console.WriteLine($"{worker.FirstName} {worker.LastName} {worker.MonthZarplata}");
            }

        }
    }
}
