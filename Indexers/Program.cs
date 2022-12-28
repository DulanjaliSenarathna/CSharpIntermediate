using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Dul";
            Console.WriteLine(cookie["name"]); //output Dul
        }
    }
}
