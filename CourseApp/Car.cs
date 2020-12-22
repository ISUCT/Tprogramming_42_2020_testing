using System;

namespace CourseApp
{
    public class Car
    {
        private bool state = false;
        private StartButton startButton1 = new StartButton();

        public Car(StartButton startButton2)
        {
            this.startButton1 = startButton2;
        }

        public string Start()
        {
            return this.startButton1.Start(state);
        }
    }
}