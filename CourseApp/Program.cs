using System;

namespace CourseApp
{
    public class Program
    {
        public static int Calc(Numer a, Numer b)
        {
            if ((a.Value == null) || (b.Value == null))
            {
                throw new NullReferenceException("a or b is null");
            }
            else
            {
                int c = (int)a.Value + (int)b.Value;
                return c;
            }
        }

        public static void Main(string[] args)
        {
            Numer a = new Numer();
            Numer b = new Numer();
            a.Value = 5;
            b.Value = 5;
            Console.WriteLine(Program.Calc(a, b));
            Console.ReadLine();
        }
    }
}
