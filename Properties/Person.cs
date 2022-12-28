using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    public class Person
    {
       
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; } //put pvt to after user set his bday and , it can't be change/readonly.so we set this in the constructor

        public Person(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }
        public int Age //we have logic here. so we can't create auto-implemented properties here
        {
            get // we don't need set method because it's doesnot sense when we set someones age. age calculation should be as follows
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
