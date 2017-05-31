using FactoryOfFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface AbstractFactory
    {
        IBrand GetBrandsInstance(string brandName);

        IProduct GetProductsInstance(string productName, string brandName);

    }
}
