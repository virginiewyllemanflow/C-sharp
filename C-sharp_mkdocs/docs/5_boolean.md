# Boolean data type

---
The boolean data type can take the values `true` and `false`, these are binaries. The boolean values are not strings.

---

- [Boolean data type](#boolean-data-type)
  - [Boolean expressions](#boolean-expressions)
    - [Comparison operators](#comparison-operators)
    - [Logical operators (aka boolean operators)](#logical-operators-aka-boolean-operators)

## Boolean expressions

Boolean expressions are expressions that return a boolean value (or in other words evaluate to a boolean). They contain **comparison operators** and/or **logical operators**. 

You can declare a boolean variable as a boolean expression, the return value will be a boolean. Boolean expressions can evaluate integers, doubles, strings, variables, and even booleans.

### Comparison operators

|Comparison operator|Description|
|---|---|
|`==`|evaluates whether the two sides of the expression are equal|
|`!=`|evaluates whether the two sides of the expression are not equal|
|`>`|evaluates whether the left side is greater than the right side|
|`<`|evaluates whether the left side is smaller than the right side|
|`>=`|evaluates whether the left side is greater than or equal to the right side|
|`<=`|evaluates whether the left side is smaller than or equal to the right side|

### Logical operators (aka boolean operators)

Logical operators can appear in boolean expressions. They take boolean values as input and as output. You can chain multiple logical statements in one boolean expression.

|Logical operator|Name|Description|
|---|---|---|
|AND|`&&`|true if both sides evaluate to true|
|OR|`II`|true if one or two sides evaluate to true|
|NOT|`!`|true if evaluates to false, false if evaluates to true|

>**Note:** `!` comes in the beginning of the expression. `AND` and `OR` come in between the two sides of the expression.


example of a boolean exercise I did:

```C#
using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      // Password declaration
      string password = "abc!de";

      // Check whether there is an uppercase character
      bool upperCheckChar = false;
      bool upperCheck = false;

      // Check if there are no symbols
      bool symbolCheckChar = false;
      bool symbolCheck = false;

      foreach (char i in password) {

        upperCheckChar = (i == Char.ToUpper(i));
        if (upperCheckChar) {
          upperCheck = true;
          break;
        }

        symbolCheckChar = ((i == Convert.ToChar("!")) || (i == Convert.ToChar("?")) || (i == Convert.ToChar(".")) || (i == Convert.ToChar("@")) || (i == Convert.ToChar("#")));

        if (symbolCheckChar) {
          symbolCheck = true;
          break;
        }
      }

      Console.WriteLine($"Contains uppercase letter: {upperCheck}");
      Console.WriteLine($"Contains symbol: {symbolCheck}");

      // Check validity of password
      bool passwordCheck = (upperCheck && !symbolCheck);
      Console.WriteLine($"Password OK: {passwordCheck}");
    }
  }
}
```