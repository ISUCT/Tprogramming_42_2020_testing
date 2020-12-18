using System;
using Xunit;
using Moq;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(-5, -5, -10)]
        [InlineData(-5, 5, 0)]
        [InlineData(0, 0, 0)]
        public void TestCalc(int x, int y, int exp)
        {
            Numer a = new Numer();
            a.Value = x;
            Numer b = new Numer();
            b.Value = y;
            Assert.Equal(exp, Program.Calc(a, b));
        }

        [Fact]
        public void TestForOneNull()
        {
            Numer a = new Numer();
            Numer b = new Numer();
            a.Value = null;
            b.Value = 1;
            Assert.Throws<System.NullReferenceException>(() => Program.Calc(a, b));
        }

        [Fact]
        public void TestForNull()
        {
            Numer a = new Numer();
            Numer b = new Numer();
            a.Value = null;
            b.Value = null;
            Assert.Throws<System.NullReferenceException>(() => Program.Calc(a, b));
        }

        [Fact]
        public void TestFuntionRun()
        {
            var mock = new Mock<ClassB>();
            mock.Setup(b => b.B(It.IsAny<int>()));
            var classA = new ClassA(mock.Object);
            var exp = classA.B();
            mock.Verify(b => b.B(It.IsAny<int>()), Times.Once());
        }
    }
}
