using System;
using Xunit;
using Moq;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(10, 20, 30)]
        [InlineData(-10, 20, 10)]
        [InlineData(0, 0, 0)]
        public void TestCalc(int aValue, int bValue, int exp)
        {
            Digit a = new Digit();
            a.Value = aValue;
            Digit b = new Digit();
            b.Value = bValue;
            var sum = Program.Calc(a, b);
            Assert.Equal(exp, sum);
        }

        [Fact]
        public void TestCalcWithANull()
        {
            Digit a = null;
            Digit b = new Digit();
            b.Value = 10;
            Assert.Throws<ArgumentNullException>(() => Program.Calc(a, b));
        }

        [Fact]
        public void TestCalcWithBNull()
        {
            Digit a = new Digit();
            a.Value = 20;
            Digit b = null;
            Assert.Throws<ArgumentNullException>(() => Program.Calc(a, b));
        }

        [Fact]
        public void TestCalcWithAllNull()
        {
            Digit a = null;
            Digit b = null;
            Assert.Throws<ArgumentNullException>(() => Program.Calc(a, b));
        }

        [Fact]
        public void TestMockFunction()
        {
            var startButtonMock = new Mock<StartButton>();
            startButtonMock.Setup(x => x.Start(It.IsAny<bool>()));
            var car = new Car(startButtonMock.Object);
            var res = car.Start();
            startButtonMock.Verify(x => x.Start(It.IsAny<bool>()), Times.Exactly(1));
        }
    }
}