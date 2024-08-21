# The Object class

---
The `Object` class is the superclass at the highest level of the class hierarchy. All classes directly or indirectly inherit from the `Object` class.

---

- [The Object class](#the-object-class)
  - [Upcasting to Object](#upcasting-to-object)
  - [Uses of the Object type](#uses-of-the-object-type)
    - [Object members](#object-members)

>**Note:** All types inherit from the `Object` class, even value types. Therefore `Object ob1 = "hello"` and `Object ob2 = 5` are valid.

## Upcasting to Object

Since `Object` is at the top of the class hierarchy, you can upcast any reference to type Object!

## Uses of the Object type

- When you don't know the type of an object, you can use `Object`
- There are some useful members in the `Object` class (properties and methods)

### Object members

Since all types inherit from the `Object` type, all types can access `Object` members. Some of these members are:

|Member|Description|Virtual?|
|---|---|---|
|`x.GetType()`|returns the type of x|no|
|`x.ToString()`|returns a string description of x|yes, you can use override|
|`x.Equals(y)`|returns true if x == y and false if x != y ([see comparison of variables](14_references_polymorphism.md#comparison-of-variables-with-boolean-expressions))|yes, you can use override|

>**Note:** `Console.WriteLine()` uses the `ToString()` `Object` method under the hood: When you pass a variable to `Console.WriteLine()`, the `ToString()` method is called on that variable and the result is printed to the console. This also means that you can change what is printed to the console by overriding the `ToString()` method in your [class definition](11_classes.md#defining-a-class).
