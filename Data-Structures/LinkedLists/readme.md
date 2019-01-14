# Singly Linked Lists

Like arrays, Linked List is a linear data structure. Unlike arrays, linked list elements are not stored at contiguous location; the elements are linked using pointers.
(https://www.geeksforgeeks.org/linked-list-set-1-introduction/)


## Challenge

- Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.
- Within your LinkedList class, include a head property. Upon instantiation, an empty Linked List should be created.
- This object should be aware of a default empty value assigned to head when the linked list is instantiated.
- Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
- Define a method called includes which takes any value as an argument and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.
- Define a method called print which takes in no arguments and outputs all of the current Node values in the Linked List.
- At no time should an exception or stack trace be shown to the end user. Catch and handle any such exceptions and return a printed value or operation which cleanly represents the state and either stops execution cleanly, or provides the user with clear direction and output.
- Be sure to follow your language/frameworks standard naming conventions (e.g. C# uses PascalCasing for all method and class names).


## API

###LinkList.Insert(int value)

This method will insert a new Node at the Head of the Linked List.
The method store the current Head to a temporary variable, then assigns the Head property of the Linked List to the instantiated Node with a value of the input "int value." Lastly it assigns the Next Property of the new Head Node to the temporary variable, this allows the chain to continue from Head to Tail (where the last Node = NULL);

This method has a return type of Void as it does not return any values.

This method has a Time efficiency of O(1) because the method nevers traverses the Linked List
This method has a Space effieciency of O(1) because the only memory reserved is for the temporary variable, this never grows or changes.

![insertMethod](Assets/insertMethod.png)

### LinkList.Includes(int value)
This method returns a boolean value if the input value exists in the Linked List it is instantiated on. The method traverses the Linked List using a while loop and once it finds a match, the method returns true. If the method traverses the entire Linked List and does not find a match it returns false.

This method has a Time efficiency of O(n) where "n" is the amount of Nodes in the Linked List. This is because in our worst case scenario (where the value does not exist in the Linked List) the method will have to traverse the entire Linked List and thus visit every Node of the Linked List.
This method has a Space efficiency of O(1) because the method does not require storage that would grow or change.

![includesMethod](Assets/includesMethod.png)

### LinkList.Print()
This method returns a string variable, where this string is the visual for a given Linked List which this method is instantiated on. This method will also write the Linked List to the console using Console.WriteLine();

This method has a Time efficiency of O(n) where "n" is the amount of Nodes in the Linked List. This method will have to visit every Node in order to add its value to the return String. 

This method has a Space efficiency of O(1) because the only memory storage for this method is the return string. This never grows or changes.