using System;
using Xunit;
using LinkedLists.Classes;

namespace LinkedListTests
{
    public class InsertTest
    {
        [Fact]
        public void InsertOneValue()
        {
            LinkList lL = new LinkList();

            lL.Insert(5);
            Assert.Equal(5, lL.Head.Value);
        }
        [Fact]
        public void InsertTwoValues()
        {
            LinkList lL = new LinkList();

            lL.Insert(5);
            lL.Insert(9);
            Assert.Equal(9, lL.Head.Value);
        }
        [Fact]
        public void InsertZeroValues()
        {
            LinkList lL = new LinkList();

            Assert.Null(lL.Head.Value);
        }
    }
    public class IncludesTest
    {
        [Fact]
        public void ValueAtTail()
        {
            LinkList lL = new LinkList();

            lL.Insert(1);
            lL.Insert(3);
            lL.Insert(4);

            Assert.True(lL.Includes(1));
        }
        [Fact]
        public void ValueDNE()
        {
            LinkList lL = new LinkList();

            lL.Insert(2);
            lL.Insert(3);
            lL.Insert(4);

            Assert.False(lL.Includes(10));

        }
        [Fact]
        public void ValueAtMiddle()
        {
            LinkList lL = new LinkList();

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
            LinkList lL = new LinkList();

            lL.Insert(2);
            lL.Insert(3);
            lL.Insert(4);
            
            Assert.Equal("4 -> 3 -> 2 -> NULL", lL.Print());
        }
        [Fact]
        public void PrintSingleNodeLinkedList()
        {
            LinkList lL = new LinkList();
            Assert.Equal("-> NULL", lL.Print());
        }
    }
}
