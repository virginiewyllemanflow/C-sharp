# Alternate expressions (Method shortcuts)

---
Alternate ways of defining a [method](7_methods.md), used mostly for short methods to reduce the amount of code. They include **expression-bodied definitions** and **lambda expressions**.

---

- [Alternate expressions (Method shortcuts)](#alternate-expressions-method-shortcuts)
  - [Expression-bodied definitions](#expression-bodied-definitions)
  - [Lambda expressions](#lambda-expressions)

## Expression-bodied definitions
*aka the squid notation*

Expression-bodied definitions are methods that **contain only one expression (line)** written:
- without curly braces
- without return keyword
- with an `=>` followed by the expression

*example:*
```c#
static string MyMethod(string input) {
    return input.subString(1);
}
```

```c#
static string MyMethod(string input) => input.subString(1);
```
## Lambda expressions

Remember that some methods accept other methods as arguments? Your code might be difficult to read if your method definition is separated from the method that calls it. To increase readability, you can define your method directly inside signature of the method that calls it. The notation we use, is called a lambda expression.

**Lambda expressions are anonymous** method definitions, because they have no name

>**Note:** When the method definition is long, this might worsen readability. In that case, it might be better to separate the method definition from the method that calls it.

- For methods with one expression:
    - no access modifier, return type, name
    - no curly braces
    - no return keyword
    - no semicolon

*example:*

```c#
// Normal method definition
int[] numbers = {1,2,5,7};

static bool IsEven(int num) 
{
    return num % 2 == 0;
}

Array.Exists(number, IsEven);
```
```c#
// Lambda expression
int[] numbers = {1,2,5,7};
Array.Exists(numbers, (int num) => num % 2 == 0);
```

- For methods with more than one expression: no access modifier, return type, name (but curly braces, semicolons, and a return statement)

*example:*

```c#
// Normal method definition
int[] numbers = {1,2,5,7};

static bool IsOk(int num) 
{
    numAbs = Math.Abs(num);
    return numAbs >= 5;
}

Array.Exists(number, IsOk);
```

```c#
// Lambda expression
int[] numbers = {1,2,5,7};
Array.Exists(numbers, (int num) => {
    numAbs = Math.Abs(num);
    return numAbs >= 5;
})
```

>**Note:** Further shortcuts for lambda expressions exist:
>- If there is only one parameter, parentheses are not needed.
>- If the type of the parameter is inferred from the body, you don't need to add it.