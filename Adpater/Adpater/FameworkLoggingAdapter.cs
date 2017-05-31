using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adpater
{
    public class FameworkLoggingAdapter : IFrameworkLogger
    {
        private Ilogger mylogger;
        public FameworkLoggingAdapter(Ilogger _mylogger)
        {
            mylogger = _mylogger;
        }

        public void FarmeworkLog(string message)
        {
            mylogger.LogDetails(message);
        }
    }
}
