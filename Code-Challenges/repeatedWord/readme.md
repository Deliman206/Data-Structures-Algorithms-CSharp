# Repeated Word
Write a function that accepts a lengthy string parameter.
Without utilizing any of the built-in library methods available to your language, return the first word to occur more than once in that provided string.

## Solution
The solution for this problem domain uses a Hash Table.

```c#
using System.Collections;
```

```c#
Hashtable hashTable = new HashTable();

hashTable.Add("KEY", Value);
```
When there is a collision using the folliowing code, the program returns the value of the hastable at the given KEY.

```c#
hashTable.ContainsKey(wordFromSplitOnInput)
```
This returns a true or false

## Efficiency

#### Time
The BIG O for Time is O(n) where n the number of words in the input string

#### Space
The Big O for Space is O(n) where n is the number of entries in the Hash Table, worst case scenario every word is different and the Hash Table is of equal weight as the input string to array.

