using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{
  public  class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

    }
}
