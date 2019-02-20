# Tree Intersection
Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

Write at least three test assertions for each method that you define.

Ensure your tests are passing before you submit your solution.

## Solution

This solution uses a Hashtable to record unique values from the first tree. Then runs all the values of the second tree against the Hashtable to check for collisions. When collisions occur the KEY is added to the List returned by the method.

## Efficiency

Hashtable Lookup :
    - Time O(1)
    -Space O(1)

Tree Intersection Method: 
    - Time O(n) where n is the number of nodes in the largest Binary Tree, because both trees must be visited during this method.
    -Space O(n) where n is the number of entries in the Hashtable. Worst case scenario all node values in the first tree are unique and thus all get added to the Hashtable.


