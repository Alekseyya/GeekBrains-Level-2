using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Controllers
{
    interface IUrlView
    {
        void AddUrlToGrid(Model.Url url);
    }
}
