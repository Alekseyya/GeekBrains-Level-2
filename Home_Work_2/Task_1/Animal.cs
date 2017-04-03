using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public abstract class Animal : IFeedable
    {
        private string animalName;
        private AnimalType animalType;
        private AbstractFood.FoodType foodType;
        public string Name
        {
            get { return this.animalName; }
        }
        protected Animal(string name, AnimalType animalType, AbstractFood.FoodType foodType)
        {
            this.animalName = name;
            this.animalType = animalType;
            this.foodType = foodType;
            
        }

        public AnimalType Type
        {
            get { return this.animalType; }
        }

        public AbstractFood.FoodType FoodType { get {return this.foodType;}}

        public abstract bool IsHungry { get; set; }

        public enum AnimalType
        {
            Fish,
            Bird,
            Wolf,
            Pig,
            Squirrel
        }

        public abstract void Feed(AbstractFood abstractFood);
    }
}
