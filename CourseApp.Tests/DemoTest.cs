using System;
using Xunit;
using Moq;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void NullException()
        {
            Car car1 = new Car();
            var result = Assert.Throws<ArgumentNullException>(() => car1.Sum(null)).Message;
            Assert.Equal("Value cannot be null.\r\nParameter name: One or more values is null.", result);
        }

        [Fact]
        public void TestFuntionRun()
        {
            var mockAnotherService = new Mock<TouchPad>();
            var motherBoard1 = new MotherBoard(mockAnotherService.Object);
            var result = motherBoard1.Touch();
            Assert.Equal(1, result);
        }
    }
}
