using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_EncapsulateAlgo
{
    //code to interface{abstract or interface class}
    interface IDeveloperStrategy
    {
         void DevelopAssignedFunctionality(List<string> functionalityToBeImplemented);
    }
}
