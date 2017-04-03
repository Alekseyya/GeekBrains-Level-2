using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Strawberry : AbstractFood
    {
        public Strawberry(string name) : base(name, AbstractFood.FoodType.FruitAndBerries) { }
    }
}
