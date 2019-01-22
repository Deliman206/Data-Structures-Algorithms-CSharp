# Stacks and Queues

This project has two classes: 
- Stacks
- Queues

These classes can be implemented putting the following namespcae call at the top of the file

`using StacksQueues.Classes`

Now that the classes have been called to the project they can be instantiated using the class name 

- `Stacks` for creating a stack
- `Queues` for creating a queue

## Stacks
The `Stacks` class has one property and three methods 

```C#
public class Stacks
{
  public Node top { get; set; } = null;

  public void Push(Node node)
  {
      Node temp = top;
      top = node;
      node.Next = temp;
  }
  public Node Pop()
  {
      try
      {
          Node temp = top;
          top = top.Next;
          return temp;
      }
      catch (Exception e)
      {
          Console.WriteLine(e);
          throw;
      }
  }
  public Node Peak()
  {
      return top;
  }
}
```

### Push
The push method puts a new node at the "top of the stack".
To do this a Node class is taken in and assigned to the stack's "top" property.
To save the reference to the rest of the stack, the "Next" property of our new "top Node" is assigned to the previous "top Node".

### Pop
The pop method removes the "top Node" from the stack and returns the Node.
This method is wrapped in a "try/catch" because it is possible to call the Pop method on an empty Stack but this should return a Null Refference Exception.
Finally the connection the Node to Pop will preserve its connection and reassign the top to the next Node.

### Peak
This methos simply returns the Node on the top of the stack.
It does not maniplate the stack.

------------------------------------------------------------------------------

## Queues
The `Queues` class has two property and three methods

```C#
public class Queues
{
  public Node front { get; set; } = null;
  public Node rear { get; set; } = null;

  public void Enqueue(Node node)
  {
      if (front == null)
      {
          front = node;
          rear = node;
          return;
      }
      rear.Next = node;
      rear = node;
  }
  public Node Dequeue()
  {
    try
    {
      Node dequeueNode = new Node(front.Value);
      front = front.Next;
      return dequeueNode;
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }
  }
  public Node Peak()
  {
    return front;
  }
}
```

### Enqueue
This method pushes a node into the queue at the rear. If it is the first node in the queue, then it pushes the node to the front as well.

### Dequeue
The method pushes a node off the front of the queue and returns the node. The Node directly behind becomes the front node.

### Peak
This method looks at the Node in the front of the queue. It returns the Node and does not manipulate the queue.
