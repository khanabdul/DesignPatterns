using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCar_Factory
{
    class AutoFactory
    {
        public BaseAuto GetInstance(string carType)
        {
            switch (carType)
            {
                case "maruti":
                    return new Maruti();
                case "hyundai":
                    return new Hyundai();
            }
            return null;
        }
    }
}
