using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adpater
{
    public class ConsoleLogger:Ilogger
    {
        public void LogDetails(string message)
        {
            Console.WriteLine("Console Logger : "+message);
        }
    }
}
