using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class ValidationFacade
    {
        private PlanLevelValidation _planValidation;
        private productLevelValidation _productValidation;

        public ValidationFacade(PlanLevelValidation planval  ,productLevelValidation productval )
        {
            _planValidation = planval;
            _productValidation = productval;
        }

        public bool checkifPlanAndProductNotNull(string planNumber , string ProductNumber)
        {
            return _planValidation.IsPlanNotNull(planNumber) && _productValidation.IsProductNotNull(ProductNumber);
        }

        public bool checkifPlanAndProductValid(string planNumber, string ProductNumber)
        {
            return _planValidation.IsPlanValid(planNumber) && _productValidation.IsproductValid(ProductNumber);
        }
    }
}
