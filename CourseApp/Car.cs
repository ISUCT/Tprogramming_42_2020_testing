using System;

namespace CourseApp
{
    public class Car
    {
        private object firstSpeed = 12.9;

        public double Sum(object secondSpeed)
        {
            if ((firstSpeed == null) || (secondSpeed == null))
            {
                throw new ArgumentNullException("One or more values is null.");
            }

            double sum = (double)firstSpeed + (double)secondSpeed;
            return sum;
        }
    }
}