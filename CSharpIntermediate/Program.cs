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

        //create person object from a string.
        public static Person Parse(string str)//returns the person object. that's why method return type is Person
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Nisitha");
            person.Introduce("Dulanjali");
        }
    }
}
