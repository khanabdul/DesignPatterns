using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryOfFactory;

namespace ConcreteProduct
{
    public class Honey : IProduct
    {
        public Honey(string BrandName)
        {
            _BrandName = BrandName;
        }

        private string _BrandName;

        public void GetProduct()
        {
            Console.WriteLine("------Here is your Tasty honey from ---- " + _BrandName);
        }

    }
}
