using System;
using Xunit;
using repeatedWord;

namespace repeatedWordTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestWithComma()
        {
            string test = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            Assert.Equal("summer", Program.RepeatedWord(test));
        }
        [Fact]
        public void TestWithQMark()
        {
            string test = "My bully is Kona the big bully?";
            Assert.Equal("bully", Program.RepeatedWord(test));
        }
        [Fact]
        public void TestWithCase()
        {
            string test = "Kona the kona the dog";
            Assert.Equal("kona", Program.RepeatedWord(test));
        }
    }
}
