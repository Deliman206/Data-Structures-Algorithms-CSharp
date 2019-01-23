using System;
using Xunit;
using QueueWithStacks.Classes;

namespace QueueWithStacksTests
{
    public class EnqueueMethodTests
    {
        [Fact]
        public void EnqueueIntoEmptyQueue()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(10);

            Assert.True(queue.load.top.Value == 10);
        }
        [Fact]
        public void EnqueueIntoQueueShowConnection()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(10);
            queue.Enqueue(5);

            Assert.True(queue.load.top.Value == 5);
        }
    }
    public class DequeueMethodTests
    {
        [Fact]
        public void DequeueIntoEmptyQueue()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(10);
            queue.Enqueue(5);

            Assert.True(queue.Dequeue().Value == 10);
            Assert.True(queue.Dequeue().Value == 5);
        }
        [Fact]
        public void DequeueIntoQueueShowConnection()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(10);
            queue.Enqueue(8);
            queue.Enqueue(5);
            queue.Dequeue();

            Assert.True(queue.unload.top.Next.Value == 5);
        }
    }
}
