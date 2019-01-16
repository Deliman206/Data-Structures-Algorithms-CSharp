# kth from the end of a Linked List

## Challenge
Write a method for the Linked List class which takes a number, k, as a parameter. Return the node’s value that is k from the end of the linked list. You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

## Approach & Efficiency
Time O(n) where n is the number of nodes in the linked list
The time effieciency for the finding the k value is O(n-k), however this still has a time efficency of O(n) in worst case k = 0;
Space O(1) because no new memory is allocated for the method.

## Solution
![kthFromEndWB](../../Assets/WBKthFromTheEnd.JPG)