using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Squirrel : Animal

    {
        public Squirrel(string name) : base(name, AnimalType.Squirrel) {  }

        public override bool IsHungry { get; set; } = false;
        
        //Еда которую нужно съесть данному животному
        public override void Feed(AbstractFood abstractFood)
        {
            
        }
    }
}
