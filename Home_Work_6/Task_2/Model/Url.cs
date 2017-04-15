using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Model
{
    public class Url
    {
        public string Name { get; set; }
        public string ErrorOrLength { get; set; }
        public string StopWatch { get; set; }

        public Url(string name, string errorOrLength, string stopWatch)
        {

            this.Name = name;
            this.ErrorOrLength = errorOrLength;
            this.StopWatch = stopWatch;
        }
    }
}
