using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_EncapsulateAlgo
{
    class DeveloperLead:IDeveloperStrategy
    {
        public void DevelopAssignedFunctionality(List<string> functionalityToBeDeveloped)
        {
            Console.WriteLine("Developed by Developer Lead ");
            foreach (var item in functionalityToBeDeveloped)
            {
                Console.WriteLine(" High Performance/Readibility :  " + item);
            }
        }
    }
}
