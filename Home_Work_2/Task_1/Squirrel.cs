using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Squirrel : Animal

    {
        public Squirrel(string name) : base(name, AnimalType.Squirrel,  AbstractFood.FoodType.FruitAndBerries) {  }

        public override bool IsHungry { get; set; } = true;
        
        //Еда которую нужно съесть данному животному
        public override void Feed(AbstractFood abstractFood)
        {
            if (abstractFood.FoodName == this.FoodType)
            {
                IsHungry = false;
            }
        }
    }
}
