# Get Graph Edges

Given a business trip itinerary, and an Alaska Airlines route map, is the trip possible with direct flights? If so, how much will the total trip cost be?

Write a function based on the specifications above, which takes in a graph, and an array of city names. Without utilizing any of the built-in methods available to your language, return whether the full trip is possible with direct flights, and how much it would cost.

![WhiteBoard for Graph Get Edge Challenege](WbGraphGetEdgesChallenge.JPG)

# Efficieny
Time: O(n) where n is the number of nodes in the graph. This is because the algorithm needs to find if the input city is in the current graph, and if it is in the graph the algorithm mjst traverse the Vertex property of the graph for the node with a value equal to the input city in scope.

Space: O(1) There are no data-structures implemented with this algorithm other than referance variables.
