using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes_and_Members
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void DrawShape();

        public void Copy()
        {
            Console.WriteLine("Copy to keyboard");
        }

        public void Select()
        {
            Console.WriteLine("Select shape");
        }

    }
}
