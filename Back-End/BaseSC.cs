using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Models;

namespace Tarea1.Back_End
{
    public class BaseSC
    {
        protected NorthwindContext dataContext = new NorthwindContext();
    }
}
