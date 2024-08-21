# Conditional statements
- [Conditional statements](#conditional-statements)
  - [Types of conditional statements](#types-of-conditional-statements)
    - [if statements](#if-statements)
    - [if/else statements](#ifelse-statements)
    - [else if statements](#else-if-statements)
    - [switch statements](#switch-statements)
      - [switch statement example](#switch-statement-example)
      - [switch statement example with conditions (advanced)](#switch-statement-example-with-conditions-advanced)
    - [Ternary operators](#ternary-operators)
      - [Example of ternary operators](#example-of-ternary-operators)

>**Note:** Familiarize yourself with [boolean expressions](5_boolean.md) before you dig into this topic.

## Types of conditional statements

- `if` statements
- `if/else` statements
- `else if` statements
- `switch` statements
- Ternary operations: `?`

### if statements

`If` statements are conditional statements that execute a block of code if the condition is true. Otherwise, the code block is skipped.

```C#
if (boolean expression) 
{
    execute this code;
}
```

### if/else statements

It is an extension of the `if` statement, we add an `else` and a block of code that is executed if the if condition is false.

```C#
if (boolean expression) {
    execute this code;
}
else {
    execute this code;
}
```

>**Note:** if/else is one statement, so don't put a semicolon after the if statement if you want to add an else!

### else if statements

If you want to handle more than two possible scenario's an `if/else` statement won't be enough. For chaining if statements, use `else if`'s.

Remarks:

- You can use as many `else if`'s as you want
- You can still end with en else statement to capture any unmatched conditions, but you don't have to
- You don't put semicolons in between the statements because they are one statement.

```c#
if (boolean expression) 
{
    execute this code;
}
else if (boolean expression) 
{
    execute this code;
}
else if (boolean expression) 
{
    execute this code;
}
else 
{
    execute this code;
}
```

### switch statements

When you have a lot of different values of a variable to check (I would say >3) you can avoid the repetition of the `else if` codeblock by using `switch` statements.

>**Note:** Switch statements are not well-suited for conditional expressions. Use `else if` in that case.

- Every case has a `break` statement that allows you to exit the `switch` statement after a case has been matched and the relevant code executed.

- Every `switch` statement has a default statement that captures those instances that do not match a case.

```c#
switch(variable that is addressed) 
{
    case "enter condition":
        execute this code;
        break;
    case "enter condition":
        execute this code;
        break;
    default:
        execute this code:
        break;
}
```
#### switch statement example

```python
Console.WriteLine("Please choose a movie genre.");
      string genre = Console.ReadLine();
      switch (genre) 
      {
        case "Horror":
          Console.WriteLine("Psycho");
          break;
        case "Drama":
          Console.WriteLine("Citizen Kane");
          break;
        case "Comedy":
          Console.WriteLine("Duck Soup");
          break;
        case "Adventure":
          Console.WriteLine("King Kong");
          break;
        case "Science Fiction":
          Console.WriteLine("2001: A Space Odyssey");
          break;
        default:
          Console.WriteLine("No movie found");
          break;
      }
```

#### switch statement example with conditions (advanced)

```c#
int number = 6;
int guess = 0;
Console.WriteLine("Guess a number between 1 and 10.");

while (guess != 6) 
{
    guess = Convert.ToInt32(Console.ReadLine());
    switch (guess) 
    {
        case int n when n == number:
            Console.WriteLine("Congratulations! You guessed it.");
            break;
        case int n when ((n > number) && !(n > 10)):
            Console.WriteLine("That's too high!");
            break;
        case int n when ((n < number) && !(n < 1)):
            Console.WriteLine("That's too low!");
            break;
        default:
            Console.WriteLine("That's not a number between 1 and 10..");
            break;
    }
}
```

### Ternary operators

When you need to make a binary decision (two possible conditions) you can use a ternary operator (`?`) instead of the `if/else` statement. It has shorter syntax but is less readable.

```c#
string result = (conditional expression) ? "value of result when true" : "value of result when false"

```

#### Example of ternary operators

```c#
int pepperLength = 4;

string message = (pepperLength >= 3.5) ? "ready!":"wait a little longer";

Console.WriteLine(message);
```