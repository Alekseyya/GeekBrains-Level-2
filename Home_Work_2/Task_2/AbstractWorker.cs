using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public abstract class AbstractWorker
    {
        private string firstName;
        private string lastName;
        

        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public abstract double MonthZarplata { get; set; }
        public AbstractWorker(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            
        }
        public abstract void Zarplata();

    }
}
