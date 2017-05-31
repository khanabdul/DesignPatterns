using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_ExtendFunc
{
    public abstract class CarDecorator : ICarComponent
    {
        public ICarComponent _carComponent;

        public CarDecorator(ICarComponent CarComponent)
        {
            this._carComponent = CarComponent;
        }

        public string Make { get { return _carComponent.Make; } }

        public int Model { get { return _carComponent.Model; } }

        public Decimal Price { get { return _carComponent.Price; } }
    }
}
