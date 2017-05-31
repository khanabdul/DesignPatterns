using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCar_Factory
{
    public class Hyundai:BaseAuto
    {
        public override void SwitchOnCar() { Console.WriteLine("Hyundai Switched on"); }

        //public void SwitchOFFCar() { Console.WriteLine("Hyundai Switched off"); }

    }
}
