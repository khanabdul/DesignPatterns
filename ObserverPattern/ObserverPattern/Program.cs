using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Observer is based on Publisher Subscriber(Subjet observer) Model : 
namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            AdpGlobal adpGlobe = new AdpGlobal();
            
            AdpIndia adpIndia = new AdpIndia();
            AdpCanada adpCanada = new AdpCanada();
            
            //adding  observer to subject list
            adpGlobe.Add(adpIndia);
            adpGlobe.Add(adpCanada);

            //Create new strategy and notification to Observers
            adpGlobe.SetStrategy("New Payroll Strategy");
            adpGlobe.NotifyObserver();

            adpGlobe.SetStrategy("New HCM Strategy");
            adpGlobe.NotifyObserver();

            Console.ReadKey();

        }
    }
}
