using System;
using Xunit;
using StacksQueues.Classes;
using LinkedList.Classes;

namespace StacksTests
{
    public class PushTests
    {
        [Fact]
        public void PushIntoEmptyStack()
        {
            Stacks stack = new Stacks();
            Node node = new Node(1);
            Assert.True(stack.top == null);
            stack.Push(node);
            Assert.True(stack.top.Value == 1);
        }
        [Fact]
        public void PushIntoStack()
        {
            Stacks stack = new Stacks();
            Node nodeOne = new Node(1);
            Node nodeTwo = new Node(2);

            stack.Push(nodeOne);
            stack.Push(nodeTwo);

            Assert.True(stack.top.Value == 2);
            Assert.True(stack.top.Next.Value == 1);
        }
    }
    public class PopTests
    {
        [Fact]
        public void PopOnEmptyStack()
        {
            Stacks stack = new Stacks();

            Assert.Throws<NullReferenceException>(() => stack.Pop());
        }
        [Fact]
        public void PopOnStack()
        {
            Stacks stack = new Stacks();
            Node nodeOne = new Node(1);
            Node nodeTwo = new Node(2);

            stack.Push(nodeOne);
            stack.Push(nodeTwo);

            Assert.True(stack.Pop().Value == 2);
        }
    }
    public class PeekTests
    {
        [Fact]
        public void PeekOnEmptyStack()
        {
            Stacks stack = new Stacks();
            Assert.Null(stack.Peak());
        }
        [Fact]
        public void PeekOnStack()
        {
            Stacks stack = new Stacks();
            Node nodeOne = new Node(1);
            Node nodeTwo = new Node(2);

            stack.Push(nodeOne);
            Assert.True(stack.Peak().Value == 1);
            stack.Push(nodeTwo);
            Assert.True(stack.Peak().Value == 2);
        }
    }
    
}
