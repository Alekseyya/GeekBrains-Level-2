using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Pumpkin :AbstractFood
    {
        public Pumpkin(string name) : base(name,  AbstractFood.FoodType.Vegetables) { }
    }
}
