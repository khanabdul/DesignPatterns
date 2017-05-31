using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryOfFactory;

namespace ConcreteProduct
{
    public class ChawanPrash:IProduct
    {
        private string brandName;

        public ChawanPrash(string brandName)
        {
            // TODO: Complete member initialization
            this.brandName = brandName;
        }
        public void GetProduct()
        {
            Console.WriteLine("------Here is your Tasty ChawanPrash from ---- " + brandName);
        }
    }
}
