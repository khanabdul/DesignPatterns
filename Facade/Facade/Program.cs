using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Program 
    {
        static void Main()
        {
            string PlanNumber ="01234",  ProductNumber ="abcd";
            
            ValidationFacade vf = new ValidationFacade(new PlanLevelValidation() ,new productLevelValidation());

            vf.checkifPlanAndProductNotNull(PlanNumber ,ProductNumber);


             vf.checkifPlanAndProductValid(PlanNumber ,ProductNumber);

             Console.ReadKey();

        }
    }
}
