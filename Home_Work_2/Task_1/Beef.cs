using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Beef: AbstractFood 
    {
        public Beef(string name) : base(name, AbstractFood.FoodType.Meet) { }

    }
}
