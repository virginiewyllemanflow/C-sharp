# Loops

---
Loops are used to repeat instructions based on a set of conditions. Using loops helps you avoid writing redundant, repetitive code.

---

- [Loops](#loops)
  - [while loops](#while-loops)
  - [do ... while loops](#do--while-loops)
  - [for loops](#for-loops)
  - [foreach loops](#foreach-loops)
  - [Jump statements](#jump-statements)
    - [break](#break)
    - [continue](#continue)
    - [return](#return)


## while loops

While loops trigger as long as a condition is true. You can think of it as an [if-statement](6_conditional_statements.md#if-statements) that loops.

Syntax:
```c#
while (boolean expression) 
{
    execute this code;
}
```

>**Note:** While loops can potentially trigger indefinitely is the condition never becomes false. This is called an infinite loop and should be avoided.

## do ... while loops

Do... while loops are very similar to while loops but trigger once before assessing the while condition. This means that the loop will execute at least once.

Syntax:

```c#
do
{
    execute this code;
} while (boolean condition);
```

## for loops

For loops trigger a specific number of times. An **iterator variable** is evaluated against a stopping condition, when the expression becomes false, the loop stops.

syntax:

```c#
for (int i = 0; i < 7; i += 2)
{
    execute this code;
}
```
The three statements are:
- initialization of the iterator variable
- evaluation of the iterator against the stopping condition
- iteration statement

>**Important:**
>- Don't forget to declare the iterator variable: `int i = ..`
>- The three expressions are separated by a semicolon `;`
>- The loop stops when the stopping condition is no longer true

## foreach loops

A foreach loop triggers for each item in a collection of values/sequence. The sequence can be an [array](9_data_structures_arrays.md), a string..

syntax:

```c#
foreach (string element in arrayOfStrings)
{
    execute this code;
}
```
>**Important:** The type of the elements we are iterating over must be specified.

## Jump statements

Jump statements are keywords used to break out of loops.

### break

When encountering a `break` statement in a loop, you break out of the loop and execute the code beneath it.

syntax:

```c#
foreach (string item in arrayOfStrings)
{
    Console.WriteLine(item);
    if (item == "Stop")
    {
        break;
    }
}
// resumes here
```

### continue

When encountering a `continue` statement anywhere in a loop, you ignore the rest of the code within the loop and restart the loop from the top.

syntax:

```c#
foreach (string item in arrayOfStrings)
{
    if (item == "Skip")
    {
        continue;
        // skip is not printed, and the loop moves to the next item in the array
    }
    Console.WriteLine(item);
}

```

### return

When encountering a return statement in a method, you break out of all loops within the method. The method ends and returns what you've specified after the return keyword.

syntax:

```c#
static string MyMethod(arrayOfStrings)
{
    foreach (string item in arrayOfStrings)
    {
        if (item == "Stop")
        {
            return "Sorry, we must stop here"
        }
        Console.WriteLine(item);
    }
    return "That's all!"
}

```