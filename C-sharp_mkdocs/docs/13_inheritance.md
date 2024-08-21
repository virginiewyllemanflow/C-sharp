# Inheritance

---
Inheritance is useful when different classes share class members but also have some unique members. A superclass holds the shared members, and subclasses inherit from this superclass. Additionally, the subclasses contain their own unique members.

---

>**Note:** Are you confused by the difference between interfaces and superclasses?
> - Use interfaces for shared characteristics between classes that do not necessary have a common hierarchical parent, or when implementations of the members differs between classes.
> - Use superclasses for classes that have a common hierarchical parent and when the implementation of the shared members is exactly the same.

- [Inheritance](#inheritance)
  - [Superclass](#superclass)
    - [Syntax](#syntax)
  - [Subclass](#subclass)
    - [Syntax](#syntax-1)
  - [Visual example of superclass and subclasses](#visual-example-of-superclass-and-subclasses)
  - [Inheritance rules](#inheritance-rules)
  - [Access modifier: protected](#access-modifier-protected)
  - [Base keyword](#base-keyword)
    - [Example: constructor re-use](#example-constructor-re-use)
  - [Virtual/override modifiers](#virtualoverride-modifiers)
  - [Abstract/override modifiers](#abstractoverride-modifiers)

## Superclass

A superclass is a class that contains members that are shared by all its subclasses.

### Syntax

The syntax of a superclass is no different from a normal class, you know it is a superclass because another class implements it.

```c#
class Vehicle
{
    "shared members";
}
```

>**Note:** A superclass is also know as a base class.

## Subclass

A subclass is a class that inherits all members of its superclass, without having to duplicate their code. Additionally the subclass also has members of its own.

|Subclass member|Defined|
|---|---|
|Inherited|In superclass|
|Unique|In subclass|

>**Note:** A subclass is also known as a derived class.

### Syntax

A subclass inherits a superclass using the `:` syntax. Be careful, classes must specify the superclass they inherit before specifying any interfaces they implement.

```c#
class Car : Vehicle, IDrives, IRecyclable
{
    "unique members";
}
```

## Visual example of superclass and subclasses

```Mermaid
classDiagram
    Vehicle --> Car
    Vehicle --> Train

    class Vehicle {
        String make
        String model
        int year
        startEngine()
        stopEngine()
    }

    class Car {
        boolean isConvertible
        openTrunk()
        closeTrunk()
    }

    class Train {
        int numberOfCarriages
        coupleCarriage()
        decoupleCarriage()
    }
```

`Car` and `Train` both have all properties and methods of `Vehicle`, plus some of their own. You don't need to define the superclass properties again in the subclass. This results in less duplicate code.

## Inheritance rules

- Multiple hierarchical levels are possible: a superclass can be a subclass of another superclass.

>*For example:* `Car` is a superclass of `Audi`, but a subclass of `Vehicle`.

- A subclass can inherit from only one superclass

>**Note:** Remember that a class can implement multiple interfaces, but only inherit from one superclass.

- Classes must specify the superclass they inherit before specifying any interfaces they implement

## Access modifier: protected

Sometimes we need to set the value of a superclass property in a member of its subclass. When the access modifier for the setter is `private`, the subclass cannot access it. However, when the setter is `public`, there might be security risks.

To solve this, you can use the access modifier `protected`.
Protected enables access by the superclass and its subclasses, but not by other code.

## Base keyword

The `base` keyword can be used in subclasses to refer to members of its superclass. Just like using `this` for properties of a class instance, it can increase readability of your code.

The `base` keyword is often used to inherit the constructor of the superclass in the subclass. For another use of base, refer to [Virtual/Override modifiers](#virtualoverride-modifiers).

### Example: constructor re-use

**Before constructor re-use:**

```c#
class Vehicle
{
    public Vehicle(double speed)
    {
        this.Speed = speed;
        this.Plate = Tools.GenerateLicensePlate();
    }
    // note that Speed and Plate must have protected setters
    // to be able to access them in Car
    public int Speed
    {
        get; protected set;
    }
    public string Plate
    {
        get; protected set;
    }
}
```

```c#
class Car : Vehicle
{
    public Car(double speed)
    {
        // even though Speed and Plate are members of the superclass
        // we still prefer to use this
        // because we are constructing an instance of the subclass
        this.Speed = speed;
        this.Plate = Tools.GenerateLicensePlate();
        this.Wheels = 4;
    }
    public int Wheels
    {
        get; private set;
    }

}
```
**After constructor re-use** (note the setters in Vehicle can be set to private again)**:**

```c#
class Vehicle
{
    public Vehicle(double speed)
    {
        this.Speed = speed;
        this.plate = Tools.GenerateLicensePlate();
    }
    // note that Speed and Plate can have a private setter
    // if the base constructor is used in subclasses to set the properties
    public int Speed
    {
        get; private set;
    }
    public string Plate
    {
        get; private set;
    }
}
```

```c#
class Car : Vehicle
{
    // don't need to set the properties that are already set in base
    public Car(double speed) : base(speed)
    {
        this.Wheels = 4;
    }
    public int Wheels
    {
        get; private set;
    }

}
```

## Virtual/override modifiers

If we define a method in a superclass, our subclass also has this method. But what if we want the method to be slightly different or extended in the subclass?

- Label the method in the superclass with `virtual` (can be overwritten)
- Label the method in the subclass with `override`
- Write your new code in the subclass method. If you want to re-use parts of the superclass method, use `base.MethodName`.

*Example:*

```c#
Class Vehicle
{
    public int Speed
    {
        get; protected set;
    }
    public virtual void SpeedUp()
    {
        this.Speed += 5;
    }
}
```

```c#
Class Car
{
    public override void SpeedUp()
    {
        base.SpeedUp();
        if (this.Speed > 15)
        {
            this.Speed = 15;
        }
    }
}
```

## Abstract/override modifiers

What if you want to define a different version of the same method for every subclass of the superclass? In that case there is no default method that we can override.

You will need to define an `abstract` method in the superclass, that has no implementation:

```c#
public abstract string Describe();
```

However, if this method has no implementation in the superclass, then we cannot have instances of that superclass. This means we need to make the whole class `abstract`!

```c#
abstract class Vehicle
{
    public abstract string Describe();
}
```

Our subclasses inherit the `abstract` method and must implement it. To show that we are not just adding a new method, we also need to use `override` here:

```c#
class Car : Vehicle
{
    public override string Describe()
    {
        Console.WriteLine("blabla");
    }
}
```

>**Note:** This is very similar to interfaces, but used when you need a mix between inheritance and implementation.