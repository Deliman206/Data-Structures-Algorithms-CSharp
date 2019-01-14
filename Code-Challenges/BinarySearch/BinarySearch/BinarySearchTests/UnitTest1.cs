using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTests
{
    public class UnitTest1
    {
        [Fact]
        public void ValueDNE()
        {
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 

            Assert.Equal(-1, Program.BinarySearchIndex(sortedArray, 12));
        }
        [Fact]
        public void ValueExistsEvenLengthArray()
        {
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.Equal(3, Program.BinarySearchIndex(sortedArray, 4));
        }
        [Fact]
        public void ValueExistsOddLengthArray()
        {
            int[] sortedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.Equal(9, Program.BinarySearchIndex(sortedArray, 9));
        }
    }
}
