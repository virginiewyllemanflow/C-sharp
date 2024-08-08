# Arrays

---
Arrays are **data structures**. Data structures store larger amounts of information in an organized way. An array is a **linear list of elements of the same data type**. Each element has a specific position in the list.

>**Did you know**: A string is an array of characters. You can ask for a character using its position in the string, just like you can do with arrays.

---

- [Arrays](#arrays)
  - [Syntax](#syntax)
    - [Declaring an array](#declaring-an-array)
    - [Initializing an array](#initializing-an-array)
    - [Declaring and initializing an array](#declaring-and-initializing-an-array)
      - [An empty array](#an-empty-array)
  - [Built-in properties and methods](#built-in-properties-and-methods)
  - [Accessing array elements](#accessing-array-elements)
  - [Array editing](#array-editing)
  - [Printing an array](#printing-an-array)

## Syntax

### Declaring an array

Declare an array by declaring its [type](2_data_types.md) followed by square brackets:

```c#
string[] arrayOfStrings;
int[] arrayOfInts;
double[] arrayOfDoubles;
```

### Initializing an array

Initialize an array by calling a new instance of the array class. The elements of the array are separated by commas and encapsulated in curly brackets:

```c#
arrayOfStrings = new string[] {"hallo", "beer", "kijken"};
```

>**Note:** We [instantiating an object](11_classes.md#instantiation-of-an-object) from the class Array, but the syntax deviates from the standard: use `type[]` instead of `Array`.

### Declaring and initializing an array

You can also declare and initialize the array in one step, in that case you don't need to use the `new type[]` syntax:

```c#
string[] arrayOfStrings = {"hallo", "beer", "kijken"};
```
#### An empty array

What is you don't know yet what the content of your array will be? You can declare an empty array as follows:

```c#
string[0] arrayOfStrings = new string[8];
```

- This array has 8 strings
- This array now contains *null* values at every position

>**Note:** Empty arrays of strings contain *null* as values, empty arrays of integers contain 0 as values.

## Built-in properties and methods

|[Property](11_classes.md#properties)/method|Description|
|---|---|
|`arrayX.Length`|Returns the number of elements in the array|
|`Array.IndexOf(arrayX, valueX)`|Returns the index of `valueX` in `arrayX`|
|`Array.Sort(arrayX)`|Returns an array with the same elements as the input but in ascending order (`int[]`, `float[]`...), or alphabetical order (`char[]` and `string[]`)|
|`Array.Find(arrayX, lambda expression)`|Returns the first element of `arrayX` that matches the condition defined in the lambda expression|
|`Array.Reverse(arrayX)`|Returns an array in which the elements are rearranged from last to first|
|`Array.Clear(arrayX)`|Returns an empty array (null or 0 as values), optionally define the range you want to clear (overload method)|

[Documentation of all Array class properties and methods](https://learn.microsoft.com/en-us/dotnet/api/system.array?view=net-8.0)

## Accessing array elements

As mentioned before, every element in the array has a position. We call this the index of the element. The first element has an index of 0, the second an index of 1, the third and index of 2...

*Example:* Access the third element of the arrayOfStrings

```c#
string thirdElement = arrayOfStrings[2];
```

## Array editing

Arrays are initialized to have a predefined length. this cannot be changed.
However, the elements of the array can be changed as follows:

```c#
arrayOfStrings[1] = "newvalue";
```
The second element of `arrayOfStrings` has now changed to "newvalue" overwriting the element that was there before.

## Printing an array

Printing an array to the console does not print its contents. Instead you need to use the `String.Join(string, string[])` method to concatenates all the elements of a string array (`string[]`), with a specific separator (`string`).

*Example:* 

```c#
string[] nationalities = {"belgian", "dutch", "german", "american"};
Console.WriteLine(String.Join("\n", nationalities));
/* output will be: 
"belgian"
"dutch"
"german"
"american"*/
```