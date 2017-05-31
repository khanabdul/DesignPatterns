using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    public interface IObserver
    {
          void Update(string updatedata);
    }



    //observers implement the Update method(Ibserver) which is called by notify() of subject
    public class AdpIndia : IObserver
    {

        public void Update(string strategy)
        {
            Console.WriteLine("Adp India Updated and started working on the basis of {0}", strategy);
        }

    }


    public class AdpCanada : IObserver
    {

        public  void Update(string strategy)
        {
            Console.WriteLine("Adp Canada Updated and started working on the basis of {0}", strategy);
        }


    }
}
    













