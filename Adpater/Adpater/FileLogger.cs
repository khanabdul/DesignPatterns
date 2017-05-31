using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adpater
{
    public class FileLogger:Ilogger
    {
        public void LogDetails(string message)
        {
            Console.WriteLine("Txt File Logger : " + message);
        }
    }
}
