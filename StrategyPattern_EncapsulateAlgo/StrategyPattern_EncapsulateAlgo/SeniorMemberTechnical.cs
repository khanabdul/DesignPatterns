using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_EncapsulateAlgo
{
    class SeniorMemberTechnical:IDeveloperStrategy
    {
        public void DevelopAssignedFunctionality(List<string> functionalityToBeDeveloped)
        {
            Console.WriteLine("Developed by Senior Member Technical");
            foreach (var item in functionalityToBeDeveloped)
            {
                Console.WriteLine(" Good Way:  "+ item);
            }
        }
    }
}
