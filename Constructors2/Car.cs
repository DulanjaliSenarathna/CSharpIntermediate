using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors2
{
    public class Car : Vehicle

    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is being initialize {0}", registrationNumber);
        }
    }
}
