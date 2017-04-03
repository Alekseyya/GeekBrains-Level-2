using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Walnut :AbstractFood
    {
        public Walnut(string name) : base(name, AbstractFood.FoodType.OtherFood) { }
    }
}
