using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Wolf: Animal   
    {
        public Wolf(string name) : base(name, AnimalType.Wolf, AbstractFood.FoodType.Meet) { }

        public override bool IsHungry { get; set; } = true;


        public override void Feed(AbstractFood abstractFood)
        {
            if(abstractFood.FoodName== this.FoodType)
            {
                IsHungry = false;
            }
            
        }
    }
}
