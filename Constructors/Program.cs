using System;

namespace Constructors
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Dul";

            var order = new Order();
            customer.Orders.Add(order);

            //check how the compiler created default constructor in IL
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            
        }
    }
}
