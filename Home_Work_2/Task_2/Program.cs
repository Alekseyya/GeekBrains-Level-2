using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Start();
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            
            Console.WriteLine(String.Format("{0:00}.{1:0,00} ",ts.Seconds, ts.TotalMilliseconds));

            
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
