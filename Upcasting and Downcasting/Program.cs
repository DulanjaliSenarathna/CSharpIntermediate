using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Upcasting_and_Downcasting
{
 
    class Program
    {
        static void Main(string[] args)
        {
            //upcasting
            Text text = new Text();
            Shape shape = text; //upcasting

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);//output 100 => both objects are referencing to same object

            StreamReader reader = new StreamReader(new MemoryStream());//object sent here (new MemoryStream) automatically upcast it's parent class (FileStream)
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);//can add a number
            arrayList.Add("Mosh");//can add a string
            arrayList.Add(new Text());//can add a object , all these objects are implicitly converted to the object class

            var anotherList = new List<Shape>();

            //downcasting
            Shape shape1 = new Text(); //at compile time. shape1 type is Shape, but run time it's type is Text.
            //if we type shape1. ,  we can't see properties defined in Text class. only see properties in Shape class. that's why we need downcast.
            Text text1 = (Text)shape1;
            //now we can access both classes properties using text1 object.
            Console.WriteLine(text1.Width);
        }
    }
}
