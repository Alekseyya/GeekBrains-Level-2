using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Zoo : IEnumerable<Animal>, IZoo
    {
        private List<Animal> animal;
        private int index = -1;
        public Zoo()
        {
            this.animal = new List<Animal>();
        }


        public void FeedAnimals(AbstractFood abstractFood)
        {
            foreach(var anml in animal)
            {
                //если жавотеное голодное
                if (anml.IsHungry)
                {
                   //Кормим данное животное
                    anml.Feed(abstractFood);
                }
                
            }
        }

        public void Add(Animal animal)
        {
            this.animal.Add(animal);
        }
        public IEnumerator<Animal> GetEnumerator()
        {
            return animal.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            if (index == animal.Count - 1)
            {
                Reset();
                return false;
            }
            index++;
            return true;


        }
        public void Reset()
        {
            index = -1;
        }

        public Animal this[int index]
        {
            get
            {
                if (index >= animal.Count)
                    return null;

                return animal[index];

            }
        }

        public void Remote(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
