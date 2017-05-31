using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    public class Database
    {
        public ILooger dblogger{get;set;}

        public Database(ILooger logger)
        {
            dblogger = logger;
        }
    }

    public class Mainframe
    {
        public ILooger mflogger{get;set;}


        public Mainframe(ILooger logger)
        {
            mflogger = logger;
        }
    }
}
