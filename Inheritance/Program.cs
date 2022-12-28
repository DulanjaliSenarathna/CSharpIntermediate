using System;

namespace Inheritance
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;//attribute from parent cls
            text.Copy();//method from parent cls

        }
    }
}
