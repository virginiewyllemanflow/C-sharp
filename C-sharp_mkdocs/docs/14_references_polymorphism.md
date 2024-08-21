# References and polymorphism

---
In C# some types are **reference types**, while others are **value types**. Variables of a value type actually hold data, while variables of a reference type hold a reference to data. 
This has implications when you assign a new variable to an existing one: a new copy of the data is created for value types, but merely a new reference to the same data is created for reference types.

---

- [References and polymorphism](#references-and-polymorphism)
  - [Reference vs Value types](#reference-vs-value-types)
    - [Reference types](#reference-types)
    - [Value types](#value-types)
    - [Assigning a new variable to an existing one](#assigning-a-new-variable-to-an-existing-one)
    - [Comparison of variables (with boolean expressions)](#comparison-of-variables-with-boolean-expressions)
  - [References of different types](#references-of-different-types)
    - [Use of references of different type than the object it refers to](#use-of-references-of-different-type-than-the-object-it-refers-to)
  - [Polymorphism](#polymorphism)
  - [Up-and downcasting of references](#up-and-downcasting-of-references)
  - [Missing vs unassigned reference variables](#missing-vs-unassigned-reference-variables)

## Reference vs Value types

### Reference types

Remember, reference types refer to a place in memory, they don't hold actual data.

The reference types in C# are:

- `class`
- `interface`
- `delegate`
- `object`
- `string` (immutable, behavior is different)
- `array`
- `dynamic`

### Value types

Remember, value types hold actual data. All primitive data types are value types.

The value types in C# are:

- `int`
- `bool`
- `char`
- `(s)byte`
- `(u)short`
- `(u)long`
- `float`
- `double`
- `decimal`
- `struct`
- `enum`

### Assigning a new variable to an existing one

When assigning a new variable to an existing one, their independence depends on wether they are value or reference types. Lets look at some examples to understand the difference.

Example value type:

```c#
int int1 = 20;
int int2 = int1;
int2 = 10;
Console.WriteLine(int1); //output: 20
Console.WriteLine(int2); //output: 10
```

Example reference type:

```c#
Forest forest1 = new Forest();
Forest forest2 = forest1;
forest1.name = "Leen"
forest2.name = "Woud";
Console.WriteLine(forest1); //output: "Woud"
Console.WriteLine(forest2); //output: "Woud"
```

### Comparison of variables (with boolean expressions)

We compare two variables with a comparison operator:

`variable1 == variable2;`

This expression performs a different check depending on wether the variables are value or reference types. The comparison expression returns `true` if the variables of type:

- value type: hold the same data (**value comparison**)
- reference type: refer to the same location in memory (**referential comparison**)

>**Note:** When two independently created objects hold class instances with the same values, the check will return `false`.

## References of different types

It is possible to create a refer to an object of a certain class (e.g. `Dog`) using a variable of its parent class (`Animal`) or with the interface (`IFourLegged`) it implements.

These references of class `Animal` or of interface `IFourLegged` are equal to the original `Dog` variable in referential comparison:

````c#
Dog pluto = new Dog();
Animal apluto = pluto;
IFourLegged ipluto = pluto;
Console.writeLine(pluto == apluto); // returns true
Console.writeLine(pluto == ipluto); // returns true
Console.writeLine(apluto == ipluto); // returns true
````
However, we can only use methods or properties of the `Animal` class on `apluto`, and we can only use the properties and methods defined in `IFourLegged` on `ipluto`. Essentially, the variables point to the same location in memory but can only access the properties and methods determined by their decalred type.

### Use of references of different type than the object it refers to

Maybe you wonder when you need reference to an object of a different type than the object itself. Let up find out through an example:

```c#
Dog pluto = new Dog();
Dog snoopy = new Dog();
Cat mousti = new Cat();
Cat kitty = new Cat();

// if we had no references of different types:
pluto.Sleep();
snoopy.Sleep();
mousti.Sleep();
kitty.Sleep();

// simplified and cleaned code thanks to references of different types
Animal[] animals = new Animal[] {pluto, snoopy, mousti, kitty};s
foreach (Animal a in animals)
{
  a.Sleep();
}
```
Imagine that you instantiate a bunch of animals from `Animal` subclasses `Dog` an `Cat`. If you want to make all of them sleep, you need to duplicate code for each variable and can't use a loop, because items in an array must be of one type. However, you can create a list of `Animal` references to your animals, and loop through it.

> **Important:** The variables in `animals` are `Animal` references to `Dog` and `Cat` objects!
> We can only call properties and methods of the `Animal` class but we will get values according to their implementation defined in the `Dog` and `Cat` classes.
> This is due to [polymorphism](#polymorphism)

>**Note:** You can also create references to the [Object type](15_object_class) if you don't know any common interfaces or base classes.

## Polymorphism

Polymorphism is a Greek word that means *to have many forms*. In C# polymorphism means that

- Object can be identified by more than one type, or referred to by more than one type.
- Objects maintain functionality unique to their data type (even if referenced with a different type, see [uses of references](#use-of-references-of-different-type-than-the-object-it-refers-to))

For a concrete example, please refer to this [video](https://www.youtube.com/watch?v=nYCMW3kfTvslymorphism).

## Up-and downcasting of references

**Upcasting** of references is **creating a base class or interface reference from a subclass reference**. This will always work and can be done implicitly.

**Downcasting** of references is **creating a subclass reference from a base class or interface reference**. This will only work when the reference referred to an object of the subclass type and must be done explicitly to acknowledge that you are taking the risk that the operation might fail.

To illustrate (`Book` is the base class and `Dissertation` the subclass):

```c#

Dissertation diss = new Dissertation();

// upcast
Book bdiss = diss;

// successful downcast: bdiss referred to a dissertation object
Dissertation ddiss = (Dissertation)bdiss;
```

```c#
Book bk = new Book();

// unsuccessful downcast: bk did not refer to a dissertation object
Dissertation dbk = (Dissertation)bk;
```

## Missing vs unassigned reference variables

In C# there is a difference between empty/missing references:

`Book bk = null;`

And unassigned references:

`Book bk2;`

You can use missing references for operations because they have a value (null), but not unassigned references. This is illustrated below:

```c#
// missing reference bk of type Book
Book bk = null;
Console.WriteLine(bk); //prints nothing because empty
Console.WriteLine(bk == null); //prints true

// unassigned reference bk2 of type Book
Book bk2;
Console.WriteLine(bk); // err: use of unassigned variable bk2
Console.WriteLine(bk2 == null); // err: use of unassigned variable bk2

// contains 5 unassigned Book type references in an array, but C# automatically then assigns null to them
Book[] books = new Book[5];
// contains 5 missing Book type references in an array (functionally equivalent to the statement above)
Book[] books = new Book[] {null, null, null, null, null}
```

