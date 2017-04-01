using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Pig : Animal
    {
        public Pig(string name) : base(name, AnimalType.Squirrel) { }

        public override bool IsHungry { get; set; } = false;


        public override void Feed(AbstractFood abstractFood)
        {

        }
    }
}
