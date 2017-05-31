using Factory;
using FactoryOfFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {

        public static void Main(string[] args)
        {
            
            Console.WriteLine("What Product Do you want");
            string productName = Console.ReadLine();


            Console.WriteLine("What Brand Do you prefer of "+productName);
            string BrandName = Console.ReadLine();

            
            FactoryCreator fof = new FactoryCreator();
            AbstractFactory brandfactory = fof.GetFactory("Brand");
            IBrand brand = brandfactory.GetBrandsInstance(BrandName);
          
            AbstractFactory productfactory = fof.GetFactory("Product");
            IProduct product = productfactory.GetProductsInstance(productName, brand.GetBrandName());
            product.GetProduct();

            Console.ReadKey();
        }
    }
}
