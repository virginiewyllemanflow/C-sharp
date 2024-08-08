# Classes

---
In C#, classes are custom data types; blueprints for creating objects. Objects are instances of a class and they can contain fields, properties, and methods. Classes can be custom-defined or built-in. Class names are in PascalCase.

---
- [Classes](#classes)
  - [Encapsulation](#encapsulation)
  - [Built-in classes](#built-in-classes)
  - [Defining a class](#defining-a-class)
  - [Instantiating an object](#instantiating-an-object)
  - [Class members](#class-members)
    - [Fields](#fields)
    - [Properties](#properties)
      - [Automatic properties](#automatic-properties)
      - [Get-only properties](#get-only-properties)
    - [Methods](#methods)
      - [Constructors](#constructors)
        - [Constructor overloading](#constructor-overloading)
    - [Public versus private class members](#public-versus-private-class-members)
    - [Static class members](#static-class-members)
      - [Static constructors](#static-constructors)
  - [Static classes](#static-classes)
  - [Main](#main)

## Encapsulation

Encapsulation is a characteristic of classes. It is the ability to bundle related data (properties) and methods into a type, and protect them from other code accessing it inappropriately. This is a key feature of object-oriented programming.

Encapsulation makes it easier to:
- reuse code
- organize code

## Built-in classes

[Data types](2_data_types.md) like `string` and [`array`](9_data_structures_arrays.md) in C# are actually classes. For instance, when you create a string variable, it is an instance of the `String` class, and you can use various methods and properties defined in the `String` class.

## Defining a class

Classes are defined in a separate file, usually called `ClassName.cs`. `Program` and other classes can access each other if they share a `namespace`, or when specified with the keyword `using`.

Syntax: Define a class `Forest` in the `namespace BasicClasses`

```c#
using System;

namespace BasicClasses
{
    class Forest {
        code of the class;
    }
}
```

## Instantiating an object

To instantiate an object means to create an instance of a class. Use the keyword `new` followed by `ClassName()`.

Syntax: Instantiate a Forest object

```c#
Forest lembeekseBossen = new Forest();
```

## Class members

### Fields

Fields are pieces of data that are variable for each instance of a class. Class fields are defined as follows:

```c#
class Forest {
    public string name;
}
```

Public fields of an object can be instantiated and called using the object name and dot notation.

```c#
Forest f = new Forest();
f.name = "Zoniënwoud";
Console.WriteLine(f.name);
```

### Properties

Some class fields also have a corresponding property. Properties have getters and setters that define the conditions to retrieve (get) or set a value. Getters and setters are methods.
While properties often have a corresponding private field, it is not strictly required. Properties are usually named with a capitalized version of the corresponding field.

>**Note:** The purpose of a corresponding private field is to encapsulate the field and limit access to it; it is not accessible from outside the class definition.

Most basic syntax:

```c#
class Forest {
    private string name;
    public string Name
    {
        // the name field is set to the value given to Name
        set {name = value;}
        // when getting the Name property you will get name
        get {return name;}
    }
}
```

```c#
Forest f = new Forest();
f.Name = "leen"; //set Name and name
Console.WriteLine(f.Name); //get Name which is name
/* because name is private,
you cannot get or set name with f.name,
you need to use f.Name. */
```

You can also limit what values can be set. 

*Example:*

```c#
class Forest {
    private string name;
    public string Name
    {
        set 
        {
            if ((value == "field") || (value == "city"))
            {
                name = value;
            }
            else
            {
                name = "Not actually a forest";
            }
        }
        get {return name;}
    }
}
```

#### Automatic properties

The basic getter and setter syntax can be shortened using automatic properties. In that case you don't need to define a field, since a hidden (private) field will be defined in the background automatically.

Long syntax:

```c#
class Forest() {
    private string name;
    public string Name {
        get {return name;}
        set {name = value;}
    }
}
```

Short syntax:

```c#
class Forest() {
    public string Name
    {get; set;}
}
```

>**Important:** If you want to use the automatic property, you cannot reference the backing field directly, you should then always refer to the property!

#### Get-only properties

In some situations you want a property to have a getter, but no setter (if you don't want the value to be freely adaptable). There are two options:

- Don't define a setter:
  
To set the value of a get-only property without setter use:
- A constructor with parameter: `this.Property = parameter;`
- An initializer `public string Property {get;} = "value";`

```c#
public int Age {
    get;
}
// Using automatic properties
```

- Define a private setter (only methods in the class can set the property value):

```c#
public int Age {
    get;
    private set;
}
// Using automatic properties
```

### Methods

[Methods](7_methods.md) are chunks of code that perform a task of action. Methods belong to classes (e.g. Program). Therefore they determine how a class instance can behave.

Methods are also called using dot notation:

`objectName.MethodName();`

Methods in a custom-defined class are defined in the same way as in the Program class: see [methods](7_methods.md). They also have an access modifier, return type and name.

>**Note:** For example you can define an automatic property with a private setter and set the value using a public method. This is a safe and robust manner to control access to the class members.

#### Constructors

Constructors are special methods that set class properties when you instantiate a new object. This eliminates the need to set all properties separately by calling their setter.

Constructors:

- Have signatures that look like other methods but they do not have a return type and their name is the same as the class name e.g. `public Forest() {}`
- Are automatically created and *parameterless* when not specifically defined
- Are called when instantiating an object:

>**Note:** It is best practice to set the properties specifically on the instance that is created, to avoid confusion. Do this by using `this.Property = field`.

```c#
Forest lembeekseBossen = new Forest();
/* The constructor is called using new
and then Forest() is the constructor */
```
- You can set properties by setting the property names equal to the constructor parameter inputs.

```c#
class Forest {
    // define constructor method
    public Forest(string name, string biome) {
        this.Name = name;
        this.Biome = biome;
        this.Age = 0;
    }
    // define automatic properties, biome can be set outside class
    public string Biome {
        get;
        set;
    }
    // define automatic get-only properties
    public string Name {
        get;
        private set;
    }
    public int Age {
        get;
        private set;
    }
}
```

```c#
//Sets properties Name and Biome (and also hidden fields)
Forest lembeekseBossen = new Forest("LB", "Continental");
```
##### Constructor overloading

Since constructors are methods, you can also have multiple versions of one constructor with a different set of parameters or functionality. This is called [overloading](7_methods.md#method-overloading).

There are three options to handle this:
- Set-up separate constructor methods, each specifying how to set all properties. This option will result in redundant code, where you assign the same property in different constructors.
- Set-up one constructor method with [default parameter values](7_methods.md#method-parameters) for optional parameters
- Set-up separate constructor methods but avoid redundant code by using `: this()` to call another constructor from the same method:

```c#
class Forest {
    public Forest(string name, string biome)
    {
        this.Name = name;
        this.Biome = biome;
    }
    // : this() calls the constructor above
    // to set this.Name of this constructor to name
    // and this.Biome to "unknown"
    public Forest(string name) : this(name, "Unknown")
    {
        // using this option you can also add additional functionality
        Console.WriteLine("No biome specified, default value used.")
    }
    public string Name {
        get; set;
    }
    public string Biome {
        get; set;
    }
}
```

### Public versus private class members

Class members have **access modifiers** that ensure protection and encapsulation of classes, either:

- **public**: accessible by other classes in the name space
- **private**: only accessible from within the class itself

It is good practice to define fields as private, and the corresponding properties as public. Since properties often include validation or conditions for setting and getting fields, defining the field as private ensures that code cannot bypass validation by directly calling or setting the field. Only the property can be used. Methods should be public unless you only want to call them from within the class.

### Static class members

Remember we talked about [static vs instance methods](7_methods.md#static-vs-instance-methods)? Not only class methods, but all class members can be static.

Static class members belong to the class itself, not to its objects. To define a static class member, use the **keyword `static`** after the access modifier and before the return type:

**access modifier - static keyword - return type - class member;**

*For example:*
```c#
public static string Description {
    get; set;
}
```

To access a static member, we use the **dot notation on the class**, not on the object (as with instance members):

```c#
// Call static property of Forest class
Console.WriteLine(Forest.Description);
// Call instance property of member "lembeekseBossen" of Forest class
Console.WriteLine(lembeekseBossen.Biome);
```
>**Important:** Static methods can only access static fields and properties.

#### Static constructors

If you want certain static fields and properties to be set, you can do this using a **static constructor**:

For example:
```c#
static Forest() {
    description = "blablabla";
}
```
The constructor:

- Uses the keyword static
- Does not accept an access modifier

>**Notes:**
> - Static constructors are automatically called before calling a static member of a class, or before instantiating a new object.
> - You cannot use non-static constructors to set static members, because they set properties and fields per class instance.

## Static classes

Not only class members, but also whole classes can be static! Static classes do not have class instances. In other words, you cannot instantiate an object from a static class. Instead, they are used to group methods, like the `Math` class. The syntax for defining static classes is:

```c#
static class ClassName
{
    
}
```

>**Note:** Since the class is static, you are not obliged to declare every member as static, although it is still best practice to do so.

## Main

Lets break down the Main() method of our Program class.

```c# 
Class Program
{
    public static void Main(string[] args)
    {
        
    }
}
```

- Program is a class
- Main() is a method of the class Program:
    - static: Main() acts on program itself, not on program instances (`Program.Main()`)
    - public: Main() can be accessed by other classes of the same namespace
    - void: Main() does not return anything
    - string[] args: Main() has one argument, args which is an array of strings

Each time you run `dotnet run`, Program.Main() is called. We can include arguments on the command line, like `dotnet run arg1 arg2 arg3` that will be converted into an array as the args parameter.