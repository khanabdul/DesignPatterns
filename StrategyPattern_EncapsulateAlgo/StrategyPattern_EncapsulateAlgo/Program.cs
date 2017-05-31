using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ABDUL Khan*/
namespace StrategyPattern_EncapsulateAlgo
{

    
/* “Strategy pattern defines a family of algorithms, encapsulates each one of them and makes them interchangeable.”

1) Family of Algorithms- The definition says that the pattern defines the family of algorithms-
    it means we have functionality (in these algorithms) which will do the same common thing for our object, but in different ways.

2) Encapsulate each one of them- The pattern would force you to place your algorithms in different 
    classes (encapsulate them). Doing so would help us in selecting the appropriate algorithm for our object.

3) Make them interchangeable- The beauty with strategy pattern is we can select at run time which
    algorithm we should apply to our object and can replace them with one another

    */

   /// <summary>
    /// Abdul Khan:  1/25/2016
   /// </summary>

    class Program
    {
        
        static void Main(string[] args)
        {
            //interface reference capable of holding different Algo Impl.
            IDeveloperStrategy developerStrategy = null;


            //work to be assigned
            List<string> easyFunctionalityToBeImplement = new List<string>() { "Easy Payrolls Work ", "Easy Finance Work ", "Easy Retirement Services Work", "Easy Automation Tests Fr. Work " };

            List<string> difficultFunctionalityToBeImplement = new List<string>() { "Difficult Payrolls Work ", "Difficult Finance Work ", "Difficult Retirement Services Work", "Difficult Automation Tests Fr. Work " };

            List<string> designfunctionalityToBeImplement = new List<string>() { "Design Payrolls Work ", "Design Finance Work ", "Design Retirement Services Work", "Design Automation Tests Fr. Work " };


            //assign easy to Meber tech.
            StrategyContext strategyContext = new StrategyContext(new MemberTechnical());
            developerStrategy = strategyContext.getFunctionalityDeveloper("easy", easyFunctionalityToBeImplement);
           
            //Difficult to Sr. Meber tech.
            //developerStrategy = StrategyContext.getFunctionalityDeveloper(difficultFunctionalityToBeImplement.First(), difficultFunctionalityToBeImplement);
            
            //Design to developer lead
            //developerStrategy = StrategyContext.getFunctionalityDeveloper(designfunctionalityToBeImplement.First(), designfunctionalityToBeImplement);
          
            Console.ReadLine();
        }



    
    }

    public  class StrategyContext
    {
        IDeveloperStrategy developerStrategy = null;
        public StrategyContext(IDeveloperStrategy DeveloperStrategy)
        {
            this.developerStrategy = DeveloperStrategy;
        }

        //logic to select the algorithms 
        public  IDeveloperStrategy getFunctionalityDeveloper(string FunctionalityToBeImplement, List<string> functionality)
        {
            string level = FunctionalityToBeImplement.Split(' ').First();
            developerStrategy.DevelopAssignedFunctionality(functionality);
            
            //switch (level)
            //{
            //    case "Easy":
            //         developerStrategy.DevelopAssignedFunctionality(functionality);
            //        break;
            //    case "Difficult":
            //        new SeniorMemberTechnical();
            //        break;
            //    case "Design":
            //        new DeveloperLead();
            //        break;
            //    default:
            //        break;
            //}
            return developerStrategy;
        }
    }
}
