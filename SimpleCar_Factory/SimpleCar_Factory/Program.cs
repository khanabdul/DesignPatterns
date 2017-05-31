using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCar_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoFactory abstarctfactory = new AutoFactory();
            
            BaseAuto marutiCar = abstarctfactory.GetInstance("maruti");
            marutiCar.SwitchOnCar();
            marutiCar.SwitchOFFCar();

            //other car
            BaseAuto hyundaicar = abstarctfactory.GetInstance("hyundai");
            hyundaicar.SwitchOnCar();
            hyundaicar.SwitchOFFCar();

            Console.ReadKey();
        }
    }
}
