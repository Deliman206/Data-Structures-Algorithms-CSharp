# Graph Data Structure

Implement your own Graph. The graph should be represented as an adjacency list, and should include the following methods:

1. AddNode()
    - Adds a new node to the graph
    - Takes in the value of that node
    - Returns the added node
    
2. AddEdge()
    - Adds a new edge between two nodes in the graph
    - Include the ability to have a “weight”
    - Takes in the two nodes to be connected by the edge
    - Both nodes should already be in the Graph
    
3. GetNodes()
    - Returns all of the nodes in the graph as a collection (set, list, or similar)
    
4. GetNeighbors()
    - Returns a collection of nodes connected to the given node
    - Takes in a given node
    - Include the weight of the connection in the returned collection
    
5. Size()
    - Returns the total number of nodes in the graph
    
    
## Efficiency

1. AddNode()
* This method relies on the Faker.Net dependacy for RandomNumber.Next()

- Time: O(1) The Node gets added to a List
- Space: O(1) The List already exists on the graph.

2. AddEdge()
- Time: O(1) The Tuple gets added to a List
- Space: O(1) The List already exists on the graph.

3. GetNodes()
- Time: O(1) Returns the property Verticies.
- Space: O(1) Verticies List exists on the graph 

4. GetNeighbors()
- Time: O(n) where n is the number of Tuples in the List of Edges on the graph
- Space: O(1) Edges list exists on the graph

5. Size()
- Time: O(n) where n is the number of nodes in the List of Vertices on the graph.
- Space: O(1) Verticies List exists on graph

## White Board
![Breadth First Graph  Traversal](../Assets/WbBfg.jpeg)
![Depth First Traversal](../Assets/WbDepthFirstGraph.jpeg)
