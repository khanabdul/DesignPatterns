using FactoryOfFactory;
using PatanjliFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class FactoryCreator
    {
        public AbstractFactory GetFactory(string factoryName)
        {
            switch (factoryName)
            {
                case "Brand":
                    return new BrandsFactory();

                case "Product":
                    return new ProductFactory();
            }
            return null;
        }
    }
}
