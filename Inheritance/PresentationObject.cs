using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
   public class PresentationObject
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to keyboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}
