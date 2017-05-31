using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCar_Factory
{
    public class Maruti :BaseAuto
    {
        public override void SwitchOnCar() { Console.WriteLine("Maruti Switched on"); }

        //public void SwitchOFFCar() { Console.WriteLine("Maruti Switched off"); }


    }
}
