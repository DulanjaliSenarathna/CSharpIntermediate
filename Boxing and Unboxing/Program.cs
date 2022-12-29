using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing_and_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1); //this parameter accept object, but in here we pass the value type. so in here boxing is happening
            list.Add(DateTime.Today);//this parameter accept object class. object cls is the base cls in .net and because of this we can give any type of objects . such as numbers, string ,custom objects etc.
            list.Add("Dul");//boxing not happent , string is a reference type 

            var number = (int)list[1]; // throwing invalid cast exception, because second element is string type. string type can't cast to int type.

            //to avoid boxing, we can use generic List
            var list1 = new List<int>();// we can add only int items to List, so type safe. no boxing happens
            list1.Add(1);
        }
    }
}
