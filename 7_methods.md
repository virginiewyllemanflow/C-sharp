# Methods

---
Methods are reusable sets of instructions to perform a certain task. Some methods are built-in to C#, but you can also define your own.

---

- [Methods](#methods)
  - [Calling a method](#calling-a-method)
  - [Input: arguments](#input-arguments)
  - [Capturing method output](#capturing-method-output)
  - [Chaining methods](#chaining-methods)
  - [Creating a new method](#creating-a-new-method)
    - [Method parameters](#method-parameters)
      - [Calling a method with arguments in a different order](#calling-a-method-with-arguments-in-a-different-order)
  - [Method overloading](#method-overloading)
  - [Method output](#method-output)
    - [Return](#return)
    - [Out](#out)
      - [Method declaration with out](#method-declaration-with-out)
      - [Method calling with out](#method-calling-with-out)
  - [Methods as method arguments](#methods-as-method-arguments)
  - [Static vs instance methods](#static-vs-instance-methods)
    - [Static methods](#static-methods)
    - [Instance methods](#instance-methods)

## Calling a method

You can call a method by writing the method's name and adding parentheses.

e.g. Console.WriteLine();

## Input: arguments

arguments are input you can provide to some methods. Arguments are provided in the parentheses when calling a method.

e.g. Console.WriteLine("hello"); The argument of this method is the string "hello"

When there is more than one argument, use comma's to separate them.

e.g. Math.Min(3,5)

## Capturing method output

Some methods **return** a value, how can you capture this output? You can do this using a variable

e.g. int minNumber = Math.Min(2,5);

## Chaining methods

You can chain multiple methods. The innermost method returns a value that is used as the input for the outer method.

e.g. Console.WriteLine("hello".Substring(2,2));

## Creating a new method

Methods in C# have PascalCase names. The syntax for method definitions looks like this:

```c#
static void MyMethod()
{
    Code block that is executed when you call the method;
}
```

In C# the code that your program runs is encapsulated in the `Main` method. All other method definitions, should be placed outside of the definition of `Main()`.

```c#
static void MyMethod()
```

This part is the **method declaration**. It consists of:
- an **access modifier** (public, private)
- optional keywords (like [static](#static-methods))
- a **return type** (void, meaning that nothing is returned)
- a **name** (MyMethod).

>**Note:**
> - Sometimes no access modifier is specified, within a [class](11_classes.md) the default is `private` and within an interface it is always `public`.
> - Sometimes no return type is needed (e.g. the [constructor method](11_classes.md#constructors) of a class)

### Method parameters

To allow your own methods to accept input arguments, we need to define placeholders for those arguments and instruct the method what to do with them. These argument placeholders are called parameters.

The syntax looks like this (of course the method could contain any code):

```c#
static void MyMethod(string myFirstParameter, int mySecondParameter = 0)
{
    Console.WriteLine(myFirstParameter, mySecondParameters);
}
```

- When there is more than one parameter, they are separated by a comma
- When you want a parameter to be optional use `=` and a default value (if you don't do this you will get errors when calling the method because you did not define a parameter)

>**Note:** Parameters can only be used within the scope of their methods, because they are not defined outside of the method.

#### Calling a method with arguments in a different order

Arguments are passed to methods in the order the parameters are defined. You might get in trouble when a method has multiple optional parameters, and you want to pass an argument of the third parameter only. To fix this problem, you can name your arguments with the parameter name. In that case, the order does not matter anymore.

Example:

```c#
static void MyMethod(
    int myFirstP = 0,
    int mySecondP = 1,
    int myThirdP = 2,
    int myForthP = 3)
{
    ...
}
static void Main()
{
    MyMethod(myThirdP: 3, myFirstP: 2);
}
```

## Method overloading

Method overloading is a term used for when there are several methods with the same name but different parameters or a different number of parameters. This is useful if you want the same method to have different behavior based on its inputs.

A method **signature** or declaration, on the other hand, is unique. It is the combination of the method name, its parameters and their order.

## Method output

Method declarations contain the return type of their output. **Void** means there is no output value. If a method returns a type different from the stated return type, it will throw an error.

### Return

Return is a keyword that is used in method code to allow it to return a value or variable. When return is used in a method, you must specify the type of the returned value in the method declaration as follows:

```c#
static int MyMethod() 
{
    return 1+5;
}
```

### Out

The return keyword only allows you to return one value. What if you want your method to return more than one value? You can use return for the first value, and the **out** keyword for other values. 

#### Method declaration with out

You use out in a parameter, with the syntax:

```c#
static string MyMethod(string name, out int age) 
{
    age = 25;
}
```
- You must declare the out parameter with a type.
- Out can only output a variable, because otherwise we can specify where it is stored.
- The out parameter (`age`) must be set to a value before the method ends (before the return statement?).

#### Method calling with out

Calling the method will return the value you tell it to return AND save a value to the variable specified after out.

```c#
MyMethod("Virg", out int myAge) 
```

- If you didn't declare the out argument (`myAge`) in the main code, you need to specify its type when calling the method.
- You need to specify the out parameter both when declaring the method and when calling it.

>**Note:** Calling the method still only returns the value specified by the `return` keyword. If you want to access the `out` value, you will have to use the out variable after calling the method.

## Methods as method arguments

Some methods accept other methods as arguments, this method is then called one or more times in the body of the function using the argument (method name) and ().
The **method name (or definition) is passed as an argument**, not the method with parentheses, since that would mean executing it there.

*Example:* Array.Find() returns the first array item for which the method returns 'true'.
```c#
Array.Find(array1, Method1);
```

>**Note:** Remember that you can recognize that a method has another method as its argument by the PascalCase of methods.

## Static vs instance methods

### Static methods

Static methods belong to a class and are called on that class, not on an object of the class. To call a static method, you use the class name followed by the method name:

```c#
ClassName.MethodName(parameters)
```
*Example:*

```c#
Array.Sort(arrayX);
```

>**Note:** 
> - Static methods do not require an instance of the class to be called. Think of `Math.Floor()`, you do not need an instance of the Math class to call it.
> - The methods we define in our Program e.g. MyMethod(), are often static methods on the Program class. Because we are using the methods IN the Program class we don't need to specify the class name Program.MyMethod(), but we can shorten it to MyMethod().

>**Note:** Please refer to the documentation on [classes](11_classes.md#static-class-members) to read more about static class members.

### Instance methods

Instance methods belong to instances of a class, not the class itself. To call an instance method, you use the instance name followed by the method name:

````c#
instanceName.MethodName(parameters);
````

*Example:*

```c#
stringX.subString("a", 3);
```