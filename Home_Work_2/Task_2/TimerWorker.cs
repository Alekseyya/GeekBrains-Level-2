using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class TimerWorker : AbstractWorker
    {
        private double monthZarplata;
        private double hourlyRate;
        public TimerWorker(string firstName, string lastName, double hourlyRate) : base(firstName, lastName)
        {
            if (hourlyRate > 100 && hourlyRate <= 2000) this.hourlyRate = hourlyRate;
            else throw new Exception("Такой почасовой ставки не существует");
            Zarplata();
        }

        
        public override double MonthZarplata
        {
            get { return this.monthZarplata; }
            //возможно пригодится
            set
            {
                if (value is double) this.monthZarplata = value;
                else throw new Exception("Введено неправильное число");
            }
        } 

        //Указывать вот так зарплату через свойство хорошо, или лучше так не делать?
        public override void Zarplata()
        {
            this.MonthZarplata = 20.8 * 8 * this.hourlyRate;
        }
    }
}
