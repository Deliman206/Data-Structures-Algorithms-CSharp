using System;
using Xunit;
using LinkedList.Classes;

namespace LinkListTests
{
    public class InsertTest
    {
        [Fact]
        public void InsertOneValue()
        {
            LList lL = new LList();

            lL.Insert(5);
            Assert.Equal(5, lL.Head.Value);
        }
        [Fact]
        public void InsertTwoValues()
        {
            LList lL = new LList();

            lL.Insert(5);
            lL.Insert(9);
            Assert.Equal(9, lL.Head.Value);
        }
        [Fact]
        public void InsertZeroValues()
        {
            LList lL = new LList();

            Assert.Null(lL.Head);
        }
    }
    public class IncludesTest
    {
        [Fact]
        public void ValueAtTail()
        {
            LList lL = new LList();

            lL.Insert(1);
            lL.Insert(3);
            lL.Insert(4);

            Assert.True(lL.Includes(1));
        }
        [Fact]
        public void ValueDNE()
        {
            LList lL = new LList();

            lL.Insert(2);
            lL.Insert(3);
            lL.Insert(4);

            Assert.False(lL.Includes(10));

        }
        [Fact]
        public void ValueAtMiddle()
        {
            LList lL = new LList();

            lL.Insert(2);
            lL.Insert(3);
            lL.Insert(4);

            Assert.True(lL.Includes(3));

        }
    }
    public class PrintTest
    {
        [Fact]
        public void PrintLinkedList()
        {
            LList lL = new LList();

            lL.Insert(2);
            lL.Insert(3);
            lL.Insert(4);

            Assert.Equal("4 -> 3 -> 2 -> NULL", lL.Print());
        }
        [Fact]
        public void PrintEmptyLinkedList()
        {
            LList lL = new LList();
            Assert.Equal("NULL", lL.Print());
        }
    }
}
