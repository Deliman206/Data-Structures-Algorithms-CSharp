## Challenge
- Create a brand new PseudoQueue class. Do not use an existing Queue. Instead, this PseudoQueue class will implement the standard queue interface, but will internally only utilize 2 Stack objects. Ensure that you create your class with the following methods:

-  enqueue(value) which inserts value into the PseudoQueue, using a first-in, first-out approach.
- dequeue() which extracts a value from the PseudoQueue, using a first-in, first-out approach.
- The Stack instances have only push, pop, and peek methods. You should use your own Stack implementation. Instantiate these Stack objects in your PseudoQueue constructor.

## Efficiency

### Time

#### Enqueue(int value)
O(n) where n is the number of Nodes in the pseudo queue. The only reason this is not O(1) is because in the event all the nodes are on the unload stack, this method will have pop all Nodes off the unload onto the load stack inorder to maintain the integrity of the queue.

#### Dequeue( )
O(n) where n is the number of Nodes in the pseudo queue. The only reason this is not O(1) is because in the event all the nodes are on the load stack, this method will have pop all Nodes off the load onto the unload stack inorder to maintain the integrity of the queue.

### Space
#### Enqueue(int value)
O(1) because while a new Node is instantiated, no new stack is being created and neither the unload or load stack will have more than the total number of Nodes in the pseudo queue combines.

#### Dequeue( )
O(1) because  no new stack is being created and neither the unload or load stack will have more than the total number of Nodes in the pseudo queue combines.

## White Board
![PseudoQueue](Assets/pseudoQueue.JPG)
