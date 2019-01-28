# Binary and Binary Search Trees
Trees are computer science data structures. 

## Binary Tree

#### Efficiency

Time O(n) where is the number of nodes in the tree
Space O(h) where h is the longest path (number of edges) from the root to a leaf

### InOrder Traversal
```c#
public List<int> InOrder(Node node)
{
List<int> list = new List<int>();
InOrder(node, list);
return list;
}
private List<int> InOrder(Node node, List<int> list)
{
if (Root != null)
{
if (node.Left != null)
InOrder(node.Left, list);
list.Add(node.Value);
if (node.Right != null)
InOrder(node.Right, list);
return list;
}
else
return list;
}
```

### PreOrder Traversal
```c#
public List<int> PreOrder(Node node)
{
List<int> list = new List<int>();
PreOrder(node, list);
return list;
}
private List<int> PreOrder(Node node, List<int> list)
{
if (Root != null)
{
list.Add(node.Value);
if (node.Left != null)
PreOrder(node.Left, list);
if (node.Right != null)
PreOrder(node.Right, list);
return list;
}
else
return list;
}
```

### PostOrder Traversal
```c#
public List<int> PostOrder(Node node)
{
List<int> list = new List<int>();
PostOrder(node, list);
return list;
}
private List<int> PostOrder(Node node, List<int> list)
{
if (Root != null)
{
if (node.Left != null)
PostOrder(node.Left, list);
if (node.Right != null)
PostOrder(node.Right, list);
list.Add(node.Value);
return list;
}
else
return list;
}
```

## Binary Search Tree

### Efficiency
Time O(ln(n)): the natural log of n refers to a mathematical ratio where the time efficiency continues to cut in half during each traversal. This is because Binary Search trees are sorted after the root, lower values go to the left and higher values go to the right.

Space O(h) where h is the longest path (number of edges) from the root to a leaf.

### Add New Value
```c#
public void Add(Node node)
{
if (Root == null)
Root = node;

else
Add(Root, node); 
}
private void Add(Node root, Node node)
{
if (node.Value < root.Value)
{
if (root.Left == null)
root.Left = node;
else
Add(root.Left, node);
}            
else if (root.Right == null)
root.Right = node;
else
Add(root.Right, node);
}
```

### Conatians Value
```c#
public bool Contains(Node node)
{
if (Root == null)
return false;
if (Root.Value == node.Value)
return true;
else
return Contains(Root, node);
}
private bool Contains(Node root, Node node)
{
if (root == null)
return false;
else if(node.Value == root.Value)
return true;
else if (node.Value < root.Value)
return Contains(root.Left, node);
else
return Contains(root.Right, node);
}
```
