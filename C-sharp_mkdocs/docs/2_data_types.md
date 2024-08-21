# C# data types

- [C# data types](#c-data-types)
  - [Data type conversion](#data-type-conversion)
    - [Implicit conversion](#implicit-conversion)
    - [Explicit conversion](#explicit-conversion)
    - [Conversion using methods](#conversion-using-methods)

|Data type|description|example|
|---|---|---|
|int|whole numbers|`int intNum = 3;`|
|float|decimal numbers with less precision (+/- 7 digits)|`float floatNum = 3.14f;`|
|double|decimal numbers with double precision (+/- 15 digits)|`double doubleNum = 3.14;`|
|decimal|decimal number with the heighest precision (+/- 28 digits)|`decimal decimalNum = 3.14d;`|
|char|single characters|`char randomChar = "g";`|
|string|string of characters|`string randomString = "goodday";`|
|bool|boolean value|`bool boolValue = true;`|

>**Note:** How do you choose a data type for numerical data? If you don't need much precision consider using a float or int instead of a double or decimal, they take up less memory and result in a faster program!

## Data type conversion

### Implicit conversion

Some data types can be converted into each other implicitly. This is done by declaring the new variable of type x and simply assigning the existing variable for type y to it. However, this is only possible when no data will be lost in the conversion (double can implicitly be converted to int but not the other way around).

*Example:*

```c#
int length = 2;
double lengthDouble = length;
```

### Explicit conversion

For data types that cannot be implicitly converted because data would be lost, you can use a **cast operation**. Hereby, you accept that you will lose precision.

The syntax is:

```c#
type variable = (type)variableToConvert;
```

*Example:*

```c#
double length = 2.22;
int lengthInt = (int)length;
```

>**Note:** You can explicitly convert a variable of type char into a variable of type int and vice versa, because characters have ASCII codes which are integers.

### Conversion using methods

There are also built-in [methods](7_methods.md) that can be used for conversions that are not implicitly or explicitly possible, (like integer to string and the other way around).

*For example:*

```c#
string numberString = "33";
int number = Convert.ToInt32(numberString);
// or: int number = Int.Parse(numberString);
```

or 

```c#
int number = 33;
string numberString = number.ToString();
```
Notice that the syntax is slightly different for string to int than for int to string.