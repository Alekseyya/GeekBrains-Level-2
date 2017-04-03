using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class FixedWorker : AbstractWorker
    {
        private double monthZarplata;
        
        private double fixedZarplata;

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
        //Немного не понял как правильно сделать фиксированую зарплату. Или в конструкторе ее определять или в самом методе?
        public FixedWorker(string firstName, string lastName) : base(firstName, lastName)
        {
            Zarplata();
        }
        //Сделал в методе такой костыль
        public override void Zarplata()
        {
            this.MonthZarplata = 8000;
        }
    }
}
