using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public abstract class Add
    {
       public abstract void AddEssence(object sender, EventArgs e);
       public abstract void Update();
       public abstract void FormParamets();
       public virtual void ClearComponents(object sender, EventArgs e) { }
    }
}
