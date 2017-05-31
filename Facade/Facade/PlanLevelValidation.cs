using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class PlanLevelValidation
    {
        public bool IsPlanValid(string planNumber)
        {
            int result;
            if (int.TryParse(planNumber,out result) )
            {
                Console.WriteLine("PlanNumber is Valid");
                return true;
            }
            Console.WriteLine("PlanNumber is Invalid");
            return false;
        }

        public bool IsPlanNotNull(string planNumber)
        {
            if (!string.IsNullOrEmpty(planNumber))
            {
                Console.WriteLine("Plan is Not Empty");
                return true;
            }
            Console.WriteLine("Plan is Empty");
            return false;
        }
    }
}
