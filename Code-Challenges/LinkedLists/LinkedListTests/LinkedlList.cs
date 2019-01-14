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
            Node node = new Node(2);
            LinkList lL = new LinkList(node);

            lL.Insert(5);
            Assert.Equal(5, lL.Head.Value);
        }
        [Fact]
        public void InsertTwoValues()
        {
            Node node = new Node(2);
            LinkList lL = new LinkList(node);

            lL.Insert(5);
            lL.Insert(9);
            Assert.Equal(9, lL.Head.Value);
        }
        [Fact]
        public void InsertZeroValues()
        {
            Node node = new Node(2);
            LinkList lL = new LinkList(node);

            Assert.Equal(2, lL.Head.Value);
        }
    }
    public class IncludesTest
    {
        [Fact]
        public void ValueAtTail()
        {
            Node node = new Node(1);
            LinkList lL = new LinkList(node);

            lL.Insert(2);
            lL.Insert(3);
            lL.Insert(4);

            Assert.True(lL.Includes(1));
        }
        [Fact]
        public void ValueDNE()
        {
            Node node = new Node(1);
            LinkList lL = new LinkList(node);

            lL.Insert(2);
            lL.Insert(3);
            lL.Insert(4);

            Assert.False(lL.Includes(10));

        }
        [Fact]
        public void ValueAtMiddle()
        {
            Node node = new Node(1);
            LinkList lL = new LinkList(node);

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
            Node node = new Node(1);
            LinkList lL = new LinkList(node);

            lL.Insert(2);
            lL.Insert(3);
            lL.Insert(4);
            
            Assert.Equal("4 -> 3 -> 2 -> 1 -> NULL", lL.Print());
        }
        [Fact]
        public void PrintSingleNodeLinkedList()
        {
            Node node = new Node(1);
            LinkList lL = new LinkList(node);
            Assert.Equal("1 -> NULL", lL.Print());
        }
    }
}
