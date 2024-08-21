# Advanced info on strings

---
`String` is actually a reference type, it's a class that represents text and the value is stored as a collection of `char` objects. However, it does not have all the same characteristics as other reference types. 

---

- [Advanced info on strings](#advanced-info-on-strings)
  - [Differences with other reference types](#differences-with-other-reference-types)
  - [Strings are immutable](#strings-are-immutable)
  - [Missing, unassigned, and empty strings](#missing-unassigned-and-empty-strings)
  - [String as a class](#string-as-a-class)

## Differences with other reference types

In some regards, the `String` class/reference type behaves like value types:

- When you assign a `string` variable to an existing `string` variable, and change one instance, the other will not be changed. This is a consequence of the [immutability](#strings-are-immutable) of strings
- Comparison between two `strings` using a [boolean expression](5_boolean.md#boolean-expressions) behaves like a value comparison (values are compared, not wether they refer to the same object)

>**Note:** `string` and `String` are interchangeable, the `string` syntax is used because of its similarity to value types and not to confuse beginning programmers.

## Strings are immutable

`String` objects cannot be modified once they are created, it only seems that they can because whenever a modification operation happens, a new `string` is actually created in the background.

When you assign a new variable to an existing `string`, they initially point to the same object. However, as soon as a modification to one variable happens, a new `string` object is created and the references no longer point to the same `string` object.

## Missing, unassigned, and empty strings

Since `strings` are reference types, they can be [unassigned or missing](14_references_polymorphism.md#missing-vs-unassigned-reference-variables) (equal to `null`).

`Strings` also have a third way of remaining without value; they can be empty. Declaring an empty `string` can be done in two ways:

```c#
string a = "";
//or
string a = String.Empty;
```

The `String` class (`static`) method `IsNullOrEmpty()` accepts a `string` and returns a boolean that tells you wether or not the `string` is `null` or empty.

>**Note:** It is advised to use an empty `string` instead of a missing `string` (`null`) to avoid errors.

## String as a class

Since `String` is also a class, there are several properties and methods that can be called on `string` instances or class.

*Examples:*

- `static` method `IsNullOrEmpty()`
- `x.Replace(string, string)` replaces all instances of the first `string` by the second
- `String.Empty` `static` property
