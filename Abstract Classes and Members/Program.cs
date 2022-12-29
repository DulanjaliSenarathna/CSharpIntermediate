using System;

namespace Abstract_Classes_and_Members
{
    
   
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.DrawShape();

            var rectangle = new Rectangle();
            rectangle.DrawShape();

        }
    }
}
