using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //without tryparse (with parse)
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {

                Console.WriteLine("Conversion failed..");
            }
            //out modifier example
            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion faild");
        }

        static void UseParams()
        {
            var cal = new Calculator();
            Console.WriteLine(cal.Add(1, 2));
            Console.WriteLine(cal.Add(1, 2, 3));
            Console.WriteLine(cal.Add(1, 2, 3, 4));
            Console.WriteLine(cal.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(30, 40));
                Console.WriteLine("Point is at {0} , {1}", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at {0} , {1}", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
