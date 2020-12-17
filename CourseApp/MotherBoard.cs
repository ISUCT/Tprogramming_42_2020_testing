using System;

namespace CourseApp
{
    public class MotherBoard
    {
       private int times = 0;
       private TouchPad touchPad1 = new TouchPad();

       public MotherBoard(TouchPad touchPad2)
       {
           this.touchPad1 = touchPad2;
       }

       public int Touch()
       {
           return this.touchPad1.Touch(times);
       }
    }
}