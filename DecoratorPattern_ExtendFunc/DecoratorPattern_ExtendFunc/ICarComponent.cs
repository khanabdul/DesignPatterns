using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_ExtendFunc
{
    public interface ICarComponent
    {
         string Make { get;  }

         int Model { get;  }

         Decimal Price { get; }
    }
}
