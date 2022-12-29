using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            //implementation specific to circle
            Console.WriteLine("Draw a circle");
        }


    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            //implementation specific to circle
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            //implementation specific to circle
            Console.WriteLine("Draw a Triangle");
        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }


        public virtual void Draw()
        {

        }

       
    }
}
