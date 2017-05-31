using FactoryOfFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteBrand
{
    public class Dabur:IBrand
    {
        public string GetBrandName()
        {
            Console.WriteLine("----This Is a Dabur Brand----");
            return "Dabur";
        }
    }
}
