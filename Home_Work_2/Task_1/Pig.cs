using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Pig : Animal
    {
        public Pig(string name) : base(name, AnimalType.Pig, AbstractFood.FoodType.Vegetables) { }

        public override bool IsHungry { get; set; } = true;


        public override void Feed(AbstractFood abstractFood)
        {
            if (abstractFood.FoodName == this.FoodType)
            {
                IsHungry = false;
            }
        }
    }
}
