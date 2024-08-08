using System;
using System.Net;

namespace LibraryApp
{
    class Library
    {
        // fields
        private List<Book> books = new List<Book>();
        // properties
        // constructors
        // methods
        // this method take a Book instantiation as input and adds the book to a list of book objects
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void ViewBooksByAuthor(string author)
        {
            //list of books that has the author
            List <Book> booksByAuthor = books.FindAll(book => book.Author == author);
            if (booksByAuthor.Count == 0)
            {
                Console.WriteLine("No books by that author!");
            }
            else
            {
                //print line to announce you will print books
                Console.WriteLine($"The books by {author} are:");
                //print titles and summary of those books
                foreach (Book i in booksByAuthor)
                {
                    Console.WriteLine($"{i.Title}\nsummary:\n{i.Summary}");
                }
            }
        }
        public void ViewBookByTitle(string title)
        {
            Book bookX = books.Find(book => book.Title == title);
            if (bookX == null)
            {
                Console.WriteLine("No books by that title in library!");
            }
            else
            {
                Console.WriteLine($"The book {title} is by {bookX.Author}.\n The summary is: {bookX.Summary}");
            }
        }
        public void InLibrary(string title)
        {
            if (books.Exists(book => book.Title == title))
            {
                Console.WriteLine($"{title} is present!");
            }
            else
            {
                Console.WriteLine($"{title} is not present in this library!");
            }
        }
    }
}