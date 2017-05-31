using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class productLevelValidation
    {
        public bool IsproductValid(string productNumber)
        {
            int result;
            if (int.TryParse(productNumber,out result) )
            {
                Console.WriteLine("productNumber is Valid");
                return true;
            }
            Console.WriteLine("productNumber is Invalid");
            return false;
        }

        public bool IsProductNotNull(string productNumber)
        {
            if (!string.IsNullOrEmpty(productNumber))
            {
                Console.WriteLine("product is Not Empty");
                return true;
            }
            Console.WriteLine("product is Empty");
            return false;
        }
    }
}
