using System;
using Amazon;

namespace Access_ModifiersAll
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            //we can't access CalculateRating() , because it is declared as private
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
           // Amazon.RateCalculator calculator = new RateCalculator();
            customer.Promote();
        }
    }
}
