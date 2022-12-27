using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
   public class Customer
    {
        //if we have a class and, that class have list of objects of any type, always initialize that list to an empty list(in dafult construtor)
        public int Id;
        public string Name;
        public List<Order> Orders; 

        public Customer()
        {
            Orders = new List<Order>(); //initialize Orders list to an empty list to avoid null exception.if we need to use another constructor in below, we need to copy this line inside all of other constructors. it is ugly.
        }
       
        public Customer(int id)
            :this() // when this constructor call, 1st call the parameter less constructor
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id) // when this constructor call, 1st call the parameter with id constructor, then we don't need initialize id inside this constructor(Commented out)
        {
            //this.Id = id;
            this.Name = name;
        }
    }
}
