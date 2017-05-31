using ConcreteBrand;
using FactoryOfFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class BrandsFactory :AbstractFactory
    {
        public  IBrand GetBrandsInstance(string brandName)
        {
            switch (brandName.ToLower())
            {
                case "dabur":
                    return new Dabur();

                case "patanjili":
                    return new Patanjili();

                default:
                    return null;
            }
        }

        public IProduct GetProductsInstance(string productName, string brandName)
        { return null; }
    }
}
