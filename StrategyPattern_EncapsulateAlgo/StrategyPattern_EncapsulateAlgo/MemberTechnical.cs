using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_EncapsulateAlgo
{
    class MemberTechnical:IDeveloperStrategy
    {
        //memeber tech way of impl
        public void DevelopAssignedFunctionality(List<string> functionalityToBeDeveloped)
        {
             Console.WriteLine("Developed by Member Technical");
            foreach (var item in functionalityToBeDeveloped)
            {
                Console.WriteLine(" Poor Way Needs Review:  " + item);
            }
        }
    }
}
