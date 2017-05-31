using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    class Program
    {
        static void Main(string[] args)
        {

            //ILooger logger = new SingletonLogger();// no insatnce can be created outside of singleton code.

            Database db = new Database(SingletonLogger.Logger);

            db.dblogger.Log(": database");

            Mainframe mf = new Mainframe(SingletonLogger.Logger);
            mf.mflogger.Log(": Mainframe");

            Console.ReadKey();
        }
    }
}
