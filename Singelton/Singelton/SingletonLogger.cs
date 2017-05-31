using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    sealed class SingletonLogger : ILooger
    {
        private static SingletonLogger _loggerInstance = null;

        private static readonly object LockObject = new object();
        
        private SingletonLogger()
        { }

        public static SingletonLogger Logger
        {
            get
            {
                lock (LockObject)
                {
                    if (_loggerInstance == null)
                    {
                       
                        _loggerInstance = new SingletonLogger();
                        Console.WriteLine("instance created for first time");
                    }
                    return _loggerInstance;
                }
            }
        }



        public void Log(string logval)
        {
            Console.WriteLine("I am currently logging "+logval);
        }
    }
}
