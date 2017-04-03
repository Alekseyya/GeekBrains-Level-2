using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Office: IEnumerable<AbstractWorker>, IComparer<AbstractWorker>
    {

        public List<AbstractWorker> workers;
        public Office()
        {
            this.workers = new List<AbstractWorker>();
        }
        public void Add(AbstractWorker abstractWorker)
        {
            this.workers.Add(abstractWorker);
        }

        public int Compare(AbstractWorker a1, AbstractWorker a2)
        {
            if (a1.MonthZarplata > a2.MonthZarplata)
                return 1;
            else if (a1.MonthZarplata < a2.MonthZarplata)
                return -1;
            else
                return 0;
        }
        

        public IEnumerator<AbstractWorker> GetEnumerator()
        {
            return workers.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
