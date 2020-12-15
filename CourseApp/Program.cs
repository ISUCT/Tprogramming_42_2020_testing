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
            Digit a = new Digit();
            a.Value = 10;
            Digit b = new Digit();
            b.Value = 20;
            Console.WriteLine(Program.Calc(a, b));
            Console.ReadLine();
        }
    }
}
