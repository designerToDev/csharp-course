using System;
using Xunit;
using ExampleApp;

namespace UnitTests
{
public class UnitTest1
{
        [Fact]
        public void Success()
        {
            var actual = Program.Add(2,3);
            Assert.Equal(5, actual);
        }

        [Fact]
        public void Fail()
        {
            int actual = Program.Add(2,3);
            Assert.Equal(2, actual);
        }
    }
}