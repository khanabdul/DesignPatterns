using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_ExtendFunc
{  //added functionality
    class SpecialOffer : CarDecorator
    {
        public SpecialOffer(ICarComponent carComponent)
            : base(carComponent)
        {

        }


        public string OfferName { get; set; }

        public int discountPercentage { get; set; }

        public Decimal Price
        {
            get
            {
                return _carComponent.Price - (_carComponent.Price * discountPercentage / 100);
            }
        }
    }
}
