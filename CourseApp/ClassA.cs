using System;

namespace CourseApp
{
    public class ClassA
    {
        private int a = 0;
        private ClassB b = new ClassB();

        public ClassA(ClassB b)
        {
            this.b = b;
        }

        public int B()
        {
            return this.b.B(a);
        }
    }
}