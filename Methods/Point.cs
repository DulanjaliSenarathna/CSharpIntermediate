using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            //if newLocation == null throwing an error
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            //this.X = newLocation.X;
            //this.Y = newLocation.Y; instead of this 2 lines redundent, we can call Move method here
            Move(newLocation.X, newLocation.Y);

        }
    }
}
