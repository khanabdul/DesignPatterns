using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adpater
{
    public class Program
    {
        public static void Main()
        {
            IFrameworkLogger frameworkLogger = new FameworkLoggingAdapter(new ConsoleLogger());
            BluetoothManager bm = new BluetoothManager(frameworkLogger);

            bm.Connect("Moto", "Apple");

            Console.ReadKey();
        }
    }
}
