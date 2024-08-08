# Arithmetic operations
- [Arithmetic operations](#arithmetic-operations)
  - [Simple operations](#simple-operations)
    - [shortcuts for addition and subtraction](#shortcuts-for-addition-and-subtraction)
  - [Complex operations](#complex-operations)

## Simple operations

- additions: "+"
- subtraction: "-"
- multiplication: "*"
- division: "/"
- modulo: "%" (what remains after division "rest")

>**Notes:** 
>- Arithmetic operations with integers results in integers, arithmetic operations with an integer and a double result in a double. We don't lose precision.
>- Use parentheses to indicate the order of operations as good practice.
>- Modulo can be used to check wether a number is odd or even. Just take its modulo with "2"; if the answer is zero the number was even, if the answer is one the number was odd.

### shortcuts for addition and subtraction

|Long form|Short form|
|---|---|
|`apple = apple + 1;`|`apple++;`|
|`apple = apple - 1;`|`apple--;`|
|`apple = apple + 5;`|`apple+= 5;`|
|`apple = apple - 5;`|`apple-= 5;`|

## Complex operations

For more complex mathematic operations, we can't use keyboard symbols. Instead, we use built-in [methods](7_methods.md). A lot of these are methods of the "Math" class:

|Method|Description|
|---|---|
|Math.Abs()|absolute value|
|Math.Sqrt()|square root|
|Math.Floor()|rounds down to a whole number|
|Math.Min()|returns smallest of two numbers|
|Math.Pow(x,y)|result of number x to the power of y|
|Math.Max()|returns largest of two numbers|
|Math.Ceiling()|rounds up to a whole number|

>**Note:** When you use methods like these, you can always check their documentation to see how to use them or for any restrictions. e.g. Math.Sqrt only takes positive numbers!

[def]: 1_intro.md