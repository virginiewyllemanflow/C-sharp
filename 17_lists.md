# Lists

---
Lists might remind you of [arrays](9_data_structures_arrays.md) because they have similar characteristics: both are a sequential collection of values and can hold any type. But unlike arrays, lists have a flexible length, they automatically track the number of elements in the list, and you can work with multiple list items at once using methods.

---

- [Lists](#lists)
  - [Syntax](#syntax)
    - [Accessing and editing list elements](#accessing-and-editing-list-elements)
  - [Namespace generic collections](#namespace-generic-collections)
    - [Generic collections](#generic-collections)
  - [Lists are dynamic](#lists-are-dynamic)
  - [Other built-in properties and methods](#other-built-in-properties-and-methods)
  - [Why use arrays?](#why-use-arrays)

## Syntax

To declare an array of strings we used the following syntax:

```c#
// empty array, must specify # of elements
string[] emptyArray = new string[3]
// array with values
string[] letterArray = new string[] {"x", "y", "z"};
```

To declare a list of strings we use:

```c#
// empty list, don't need to specify # of elements
List<string> emptyList = new List<string>();
// list with values
List<string> letterList = new List<string> {"x", "y", "z"};
```
### Accessing and editing list elements

The syntax for accessing and editing list elements is identical to the syntax for array element [accessing](9_data_structures_arrays.md#accessing-array-values) and [editing](9_data_structures_arrays.md#array-editing).

## Namespace generic collections

To work with lists in C#, we need to include a namespace in our code. Just add the line:

```c#
using System.Collections.Generic;
```
This references *generic collections*, a group of classes to which the list class belongs.

>**Note:** Dictionaries are also a class belonging to generic collections.

### Generic collections

Generic collections are data structures that are defined without specifying a type. Only upon creation of an instance, the type of the collection is defined (`List<string>` vs `List<double>`). The formal class name of lists is `List<T>` for this reason.

>**Note:** Even though arrays are not generic collections, there also isn't a separate class for every array type (only `System.Array`)

## Lists are dynamic

Lists are basically the dynamic version of arrays, we can add/remove one or more elements to/from the list using methods. The indexes change when list elements are removed and added. 

>**Note:** To avoid errors for trying to access index values that do not exist, you can find the max index value of a list `x` at a given moment by calling `x.Count-1`.

|Method|Description|
|---|---|
|`x.Add(elementA)`|Add one element, elementA to the list|
|`x.Remove(elementA)`|Remove one element, elementA from the list. Returns a boolean to indicate if this was successful|
|`x.AddRange(new T[] {elementA, elementB,...})`*|Add multiple elements, e.g. elementA and elementB to the list|
|`x.InsertRange(ind, new T[] {elementA, elementB,...})`*|Add multiple elements, e.g. elementA and elementB to the list at (not after!) the index specified by `ind`|
|`x.RemoveRange(new T[] {elementA, elementB,...})`*|Remove multiple elements, e.g. elementA and elementB to the list|
|`x.GetRange(ind, count)`|Returns a list containing `count` elements from list `x` starting from index `ind`|
|`x.Clear()`|Remove all elements from the list, the count also changes|

>**Note:** The `AddRange()` and `RemoveRange()` list methods accept any `IEnumerable` type. This includes lists, dictionaries, hashsets, queues, arrays...

## Other built-in properties and methods

|Property/method|Description|
|---|---|
|`x.Count`|Returns the number of elements in the list*|
|`x.Contains(elementA)`|Returns a boolean, true is the element, elementA is a member of the list|
|`x.Reverse()`|Reverses the order of the elements in the list|
|`x.Reverse(ind, count)`|Overload of `x.Reverse()` where you specify what portion of the list to reverse, `count` elements starting from `ind`|

>**Note:** For the number of elements in an array or string, we use `.Length`. For Lists we use `.Count`, this distinction stresses the difference between fixed length types and flexible types that must be counted.

## Why use arrays?

Lists actually use arrays under the hood, copying all members to a new array with the modified length whenever necessary. Therefore, using an array is faster and makes more sense when you have a fixed number of elements.