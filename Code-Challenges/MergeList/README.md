# Merge two Linked Lists

## Challenge
Write a function called mergeLists which takes two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list. Try and keep additional space down to O(1). You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

## Approach & Efficiency
Time O(n) where n is the total number of node between the the two linked lists
Space O(1) because no new memory is allocated for this method. It returns LinkList01, altered by this merge methode

## Solution
![mergeList](../../Assets/WBMergeLists.JPG)