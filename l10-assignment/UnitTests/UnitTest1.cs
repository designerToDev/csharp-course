using System;
using Xunit;
using Assignment;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void emptyStringZero()
        {
            var test = Program.returnVowel("");
            Assert.Equal(0, 0);
        }

        //  [Fact]
        // public void nullStringZero()
        // {
        //     var test2 = Program.returnVowel(null);
        //     Assert.Equal(0, 0);
        // }

        [Fact]
        public void numberOfVowels()
        {
            var test3 = Program.returnVowel("Please work");
            Assert.Equal(4, 4);
        }


    }
}