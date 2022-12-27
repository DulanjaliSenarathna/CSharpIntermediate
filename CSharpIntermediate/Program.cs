using System;

namespace CSharpIntermediate
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I'm {1}", to ,Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Nisitha";
            person.Introduce("Dulanjali");
        }
    }
}
