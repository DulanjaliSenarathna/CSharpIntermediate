using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors2
{
    
    public class Vehicle
    {
        private readonly string _registrationNumber;
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialize");
        //}

        public Vehicle(string registrationNumber)
        {
            this._registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialize {0}",registrationNumber);
        }
    }
}
