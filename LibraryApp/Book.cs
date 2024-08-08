using System;
using System.ComponentModel;

namespace LibraryApp
{
    class Book
    {
        // fields
        private int rating;
        // properties
        public string Title {
            get;
        }
        public string Author {
            get;
        }
        public string Summary {
            get;
        }
        public int Pages {
            get;
        }
        public string Lang {
            get;
        }
        public int Rating
        {
            get {return rating;}
            private set {
                if (value > 5 || value < 0)
                {
                    Console.WriteLine("Invalid rating, please rate the book on a score of 0 to 5.");
                }
                else
                {
                    rating = value;
                    Console.WriteLine($"Thank you for rating {this.Title}. You gave a score of {this.Rating}.");
                }
            }
        }
        // constructors
        public Book(string title, string author,  int pages, string summary = "No summary available.", string lang = "unknown")
        {
                this.Title = title;
                this.Author = author;
                this.Summary = summary;
                this.Pages = pages;
                this.Lang = lang;
                // increase value of static property every time instance is created
                BookCount++;
        }
        // when this constructor is called it calls the constructor above
        public Book(string title, string author, string summary = "No summary available.", string lang = "unknown") : this(title, author, 0, summary, lang)
        {
            Console.WriteLine("You did not specify the number of pages, be aware that it is set to 0.");
        }
        // methods
        public void GiveRating(int rating)
        {
            this.Rating = rating;
        }
        // property to keep track of number of books created
        static public int BookCount
        {
            get; private set;
        } 
    }
}


        