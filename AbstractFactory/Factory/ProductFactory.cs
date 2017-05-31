using ConcreteProduct;
using Factory;
using FactoryOfFactory;

namespace PatanjliFactory
{
    public class ProductFactory : AbstractFactory
    {

        public IProduct GetProductsInstance(string productName,string brandName)
        {
            switch (productName.ToLower())
            {
                case "honey":
                    return new Honey(brandName);

                case "chawanprash":
                    return new ChawanPrash(brandName);

                default:
                    return null;
            }
        }


        public IBrand GetBrandsInstance(string brandName)
        {
            return null;
        }

    }
}
