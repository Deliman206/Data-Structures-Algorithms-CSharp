# Find Max Value


## Challenge
- Write a function called find-maximum-value which takes binary tree as its only input. Without utilizing any of the built-in methods available to your language, return the maximum value stored in the tree. You can assume that the values stored in the Binary Tree will be numeric.

## Efficiency

#### Time

O(n) where "n" is the number of nodes in the Binary Tree. In order to find the largest value every node must be visited

#### Space

O(w) where "w" is the widest width of any level of the Binary Tree. Because this traversal uses a Queue to solve a top-down breadth first, the queue will never get any larger than how many nodes are present at any given level of the tree.

## White Board
![Whiteboard Find Max Value](../../Assets/WbFindMaxValue.jpeg)

