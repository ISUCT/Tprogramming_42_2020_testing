using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(Digit a, Digit b)
        {
            if ((a == null) || (b == null))
            {
                throw new ArgumentNullException("arrgs cannot be null");
            }
            else
            {
                var sum = a.Value + b.Value;
                return sum;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("----Task 1----");
            Digit a = new Digit();
            a.Value = 10;
            Digit b = new Digit();
            b.Value = 20;
            Console.WriteLine(Program.Calc(a, b));
            Console.WriteLine("----Task 2----");
            StartButton startbutton1 = new StartButton();
            Car car1 = new Car(startbutton1);
            Console.WriteLine(car1.Start());
            Console.ReadLine();
        }
    }
}
