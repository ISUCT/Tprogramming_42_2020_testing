using System;

namespace CourseApp
{
    public class TouchPad
    {
       public virtual int Touch(int times)
       {
            times++;
            return times;
       }
    }
}