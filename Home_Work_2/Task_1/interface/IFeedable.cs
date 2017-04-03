using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public interface IFeedable
    {
        /// <summary>
        /// Кормить
        /// </summary>
        /// <param name="abstractFood"> Ссылка на класс еды</param>
        void Feed(AbstractFood abstractFood);
        bool IsHungry { get; set; }
    }
}
