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

        public static void Task2()
        {
            ClassB b = new ClassB();
            ClassA a = new ClassA(b);
            Console.WriteLine(a.B());
        }

        public static void Main(string[] args)
        {
            Numer a = new Numer();
            Numer b = new Numer();
            a.Value = 5;
            b.Value = 5;
            Console.WriteLine(Program.Calc(a, b));
            Task2();
            Console.ReadLine();
        }
    }
}
