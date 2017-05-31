using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCar_Factory
{
    public abstract class BaseAuto
    {
        public abstract void SwitchOnCar();
        
        //common functionality
        public void SwitchOFFCar()
        {
            Console.WriteLine("switch off any car");
        }
            

    }
}
