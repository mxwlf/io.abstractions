using ConsoleApp;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace consoleapp.test.unit
{
    [TestClass]
    public class TestExamples
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            const int a = 1; const int b = 2;

            // Act.
            var result = Program.Sum(a, b);

            // Assert.
            result.Should().Be(3);

        }
    }
}