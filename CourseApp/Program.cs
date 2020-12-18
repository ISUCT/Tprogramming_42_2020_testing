using System;

namespace CourseApp
{
    public class Program
    {
        public static void TaskN1()
        {
            Car car1 = new Car();
            object speed = 12.3;
            Console.WriteLine(car1.Sum(speed));
        }

        public static void TaskN2()
        {
            TouchPad touchPad1 = new TouchPad();
            MotherBoard motherBoard1 = new MotherBoard(touchPad1);
            Console.WriteLine(motherBoard1.Touch());
        }

        public static void Main()
        {
            TaskN1();
            TaskN2();
            Console.ReadLine();
        }
    }
}
