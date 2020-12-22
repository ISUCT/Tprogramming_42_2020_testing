using System;

namespace CourseApp
{
    public class StartButton
    {
        public virtual string Start(bool state)
        {
            if (state == true)
            {
                state = false;
                return "Engine off";
            }
            else
            {
                state = true;
                return "Engine start";
            }
        }
    }
}