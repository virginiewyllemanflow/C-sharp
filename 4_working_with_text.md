# Working with text
- [Working with text](#working-with-text)
  - [Escape sequences in strings](#escape-sequences-in-strings)
  - [String concatenation](#string-concatenation)
  - [String interpolation](#string-interpolation)
  - [String properties and methods](#string-properties-and-methods)
  - [Bracket notation](#bracket-notation)

## Escape sequences in strings

|Escape sequence|Description|
|---|---|
|\ " \ "|quotation marks in string|
|\n|line break in string|

## String concatenation

Combine strings or strings and variables using string concatenation:

`Console.WriteLine("string1" + variable1 + "string2" + ".");`

>**Note:** If you concatenate a string with a variable of another type, it will automatically convert that variable to a string.

## String interpolation

If you want to combine variables and string text without having to use plus signs all the time, you can use string interpolation:

`Console.WriteLine($"Hello, my name is {name}. I am {age} years old.")`

>**Note:** If you interpolate a string with a variable of another type, it will automatically convert that variable to a string.

## String properties and methods

[Properties](11_classes.md#properties) (e.g. Length) request data and we use `string.Property` as syntax, methods perform actions or computations and we use `string.Method()` as syntax.

|Property|Description|
|---|---|
|`.Length`|returns the number of characters of a string|

|Method|Description|
|---|---|
|`.IndexOf(x)`|returns the index (position starting from 0) of the first char of substring x <br> returns "-1" if the substring does not exist within the string|
|`.Substring(x, y)`|returns a substring starting from position x in the original string <br> if y is specified, the substring will be y characters long|
|`.ToUpper()`|convert string to uppercase|
|`.ToLower()`|convert string to lowercase|

>**Note:** 
>- When you use methods like these, you can always check their documentation to see how to use them or for any restrictions.
>- The first character in a string has index 0. So the position 0 is the first character and position 1 is the second character.

## Bracket notation

To find the character at a certain position of a string, we use bracket notation. (This is similar to how you access values in an array):

- `string[0]` returns the first character
- `string[1]` returns the second character

>**Note:** In C# you can NOT use the index -1 to retrieve the last character of the string.