using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //acts as a subject (publisher) implements methods of subject

    public class AdpGlobal: ISubject
    {
        private List<IObserver> _adpObservers = new List<IObserver>();

        private string Strategy { get; set; }

        
        public void Add(IObserver observer)
        {
            _adpObservers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _adpObservers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in _adpObservers)
            {
                observer.Update(Strategy);
            }
        }



        public void SetStrategy(string strategy)
        {
            this.Strategy = strategy;
            Console.WriteLine("Adp Global Strategy Change : {0}", strategy);
        }
    }
}
