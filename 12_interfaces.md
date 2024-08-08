# Interfaces

---
Interfaces help check wether all classes and types are used legally to prevent type errors. They enable you to define methods and properties that are shared across classes, but implemented differently.

Interfaces make sure you don't define ten different method names for related classes.

---

- [Interfaces](#interfaces)
  - [In words](#in-words)
  - [Defining an interface](#defining-an-interface)
  - [Implementing an interface](#implementing-an-interface)
    - [Implementing more than one interface](#implementing-more-than-one-interface)


## In words

An interface is a set of properties and methods without implementation details. 

An interface can be **implemented by one or more classes**. For a class to implement an interface, it must define an implementation for *all* properties and methods of the interface.

>**Note:** A class that implements an interface may have properties and methods on top of those defined by the interface.

## Defining an interface

Interfaces are defined in a separate file, usually called `IInterfaceName.cs`. Classes can access an interface if they share a `namespace`, or when specified with the keyword `using`.

Syntax: `MyInterfaces.cs` defines an interface `Prey` in the `namespace MyInterfaces`

```c#
using System;

namespace MyInterfaces
{
    interface IPrey {
        string Description {get;}
        void Flee();
    }
}
```

- Use the keyword `interface`
- Start the interface name with `I` and use PascalCase
- Define a set of properties (with methods) and methods but no implementation
- Don't use access modifiers

>**Note:** An interface cannot define constructors and fields.

## Implementing an interface

To implement an interface means to tell a class what properties and methods it must have. Use `ClassName : IInterfaceName`.

Syntax: `Deer.cs` defines a class `Deer` that implements the `IPrey` interface

```c#
class Deer : IPrey
{
    public Deer(string description)
    {
        this.Description = description;
    }
    public string Description
    {get;}
    public void Flee()
    {
        Console.WriteLine("I'm outta here!");
    }
}
```

The syntax `class ClassName : IInterfaceName` is a promise that the class will implement an interface. If it does not, an error will be thrown. This can be seen as a check that nothing was forgotten.

>**Note:** All properties and methods defined in the interface, must be public in the class that implements it. This is because these properties and methods need to be available to other code using the interface.

### Implementing more than one interface

The syntax for a Truck class that implements two interfaces: `IAutomobile` and `IRecyclable` is:

```c#
class Truck : IAutomobile, IRecyclable
{
    code;
}

```
Just separate the implemented interfaces with a comma.