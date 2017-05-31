using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_ExtendFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            ReanultDuster duster = new ReanultDuster();

            Console.WriteLine("Renault Make : {0} Model  {1} at price  : {2}", duster.Make, duster.Model, duster.Price);

            //added Special discount

            SpecialOffer specialoffer = new SpecialOffer(duster);
            specialoffer.OfferName = "LEAP Year ";
            specialoffer.discountPercentage = 10;
            Console.WriteLine("Offer Discount % :  {0} for {1} and final DusterPrice :  {2}",specialoffer.discountPercentage,specialoffer.OfferName,specialoffer.Price);
            Console.ReadKey();
        }
    }
}
