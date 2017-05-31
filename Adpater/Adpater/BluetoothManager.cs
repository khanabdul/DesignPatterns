using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adpater
{
    public class BluetoothManager
    {
        private IFrameworkLogger logger;

        public BluetoothManager(IFrameworkLogger _logger)
        {
            logger = _logger;
        }

        public void Connect(string device1 ,string device2)
        {
            Console.WriteLine("BC successfull : "+device1 +" + "+device2);

            logger.FarmeworkLog("BC Connect Log");
        }
    }
}
