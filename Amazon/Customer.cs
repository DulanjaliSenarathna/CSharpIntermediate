using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
                Console.WriteLine("Promoted to level1");
            else
                Console.WriteLine("Promoted to level2");
        }

        private int CalculateRating() //this method is only accessible inside customer clss
        {
            return 0;
        }
    }
}
