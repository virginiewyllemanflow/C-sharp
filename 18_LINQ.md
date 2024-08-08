# LINQ

---
**LINQ** stands for **Language Integrated Query** and is a C# (add-on) feature that provides a query syntax to use in C# scripts to retrieve and manipulate data from data sources (databases, XML files...).

---

- [LINQ](#linq)
  - [Namespace](#namespace)
  - [LINQ queries](#linq-queries)
    - [return type](#return-type)
    - [Var variables](#var-variables)
    - [Queries](#queries)
      - [Query syntax](#query-syntax)
      - [Method syntax](#method-syntax)
        - [Where()](#where)
        - [Select()](#select)
      - [Query vs Method syntax](#query-vs-method-syntax)
  - [LINQ with other data structures](#linq-with-other-data-structures)


## Namespace

`System.Linq` is the namespace that we need to include in our `.cs` file if we want to use LINQ:

```c#
using System.Linq;
```

## LINQ queries

### return type

LINQ queries return either a single value or an object of type `IEnumerable[T]`. The length of `IEnumerable[T]` objects can be assessed with `x.Count()`, and we can use `foreach` loops on them.

>**Note:** `Count()` is a method that is available thanks to the namespace `System.Linq`, don't confuse it with the `Count` property of [Lists](17_lists.md).

### Var variables

When we write a LINQ query, we usually save the result in a variable. However, we might not always be sure of the return type. How do we initialize the variable without a type in C#?

The solution is the `var` keyword, it indicates that the C# compiler should determine the type of the variable.

### Queries

The same LINQ query can be written in either Query syntax or Method syntax.

Since `where/Where()` and `select/Select()` can be used either as keywords or as methods, we simply call them operators in the context of LINQ

#### Query syntax

Query syntax looks similar to SQL and is usually a multi-line statement.

They are `from - where - select` statements, or `from - select` statements. Only `where` is optional. Lets look at each part separately with an example:

```c#
var longNames = from name in names
where name.Length > 10
select name.ToUpper();
```

- `from` iterates over the elements of the data structure
- `where` assesses a condition for each member, and filters elements that meet the condition
- `select` determines what is returned for each (filtered) element, can be just the element or a transformed element

#### Method syntax

Method syntax looks more similar to regular C#, and is a method call. LINQ Methods can be chained in one statement.

##### Where()

The `Where()` method:

```c#
var longNames = names.Where(n => n.Length > 10);
```

`Where()` takes a lambda expression to assess each element of the data structure against a condition. Each element for which `true` is returned is added to the new collection.

##### Select()

The `Select()` method is used when we want to transform elements of a data structure. It can be all elements or elements filtered by the `Where()` method:

```c#
// select to transform all elements in a data structure
var upperNames = names
.Select(n => n.ToUpper());
// filter some elements and then select to transform them
var longUpperNames = names
.Where(n => n.Length > 10)
.Select(n => n.ToUpper());
```

`Select()` takes a lambda expression.

#### Query vs Method syntax

The rule of thumb is to use Method syntax for single-operator queries and Query syntax for all other queries.

## LINQ with other data structures

We can use LINQ for arrays, but also for lists. The syntax is the same. Basically, any type that supports `foreach` loops can be used.