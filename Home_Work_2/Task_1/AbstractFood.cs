using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public abstract class AbstractFood
    {
        private string nameFood;
        private FoodType foodType;

        public enum FoodType
        {
            Meet,
            Vegetables,
            FruitAndBerries,
            OtherFood
        }
        
        public string NameFood
        {
            get { return this.nameFood; }
            
        }
        public FoodType FoodName
        {
            get { return this.foodType; }

        }

        protected AbstractFood(string nameFood, FoodType foodType)
        {
            this.nameFood = nameFood;
            this.foodType = foodType;
        }
        
    }
}
