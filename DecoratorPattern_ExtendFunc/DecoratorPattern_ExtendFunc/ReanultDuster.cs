using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_ExtendFunc
{
    public class ReanultDuster:ICarComponent
    {
        public string Make { get { return "2012"; } }

        public int Model { get { return 1; } }

        public Decimal Price { get { return 100000; } }
    }
}
