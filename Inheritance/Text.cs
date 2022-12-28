using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        public void AddHyperlink(string link)
        {
            Console.WriteLine("Added a link to" + link);
        }
    }
}
