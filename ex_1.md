# Exercise 1: Library Management System

This exercise combines your knowledge of classes, conditional statements, loops, methods, and arrays in C#. This exercise will involve creating a small application to manage a list of books in a library.

## Objective

Create a simple library management system where you can add books, view books, and search for books by title.

## Notes and plan

Components:

- library: instance of a library class
  - methods: 
    - AddBook: add book to the library
    - InLibrary: check if book is present in library (title and author or only author)
    - ViewBook: get book either by title and author, view short summary
  - fields and properties:
    - books = list of book object
- books: instances of a book class
  - methods: 
    - AddBook: add book to the library
    - InLibrary: check if book is present in library (title and author or only author)
    - ViewBook: get book either by title and author, view short summary
  - fields and properties:
    - title
    - author
    - short summary
    - number of pages
    - language
    - review

Questions:

- book.Rating returns 0 if you have not given it a rating yet, how can i make a difference between 0 because someone rated it 0 and 0 because there was no rating yet, and print that to the console?
  
## C# code