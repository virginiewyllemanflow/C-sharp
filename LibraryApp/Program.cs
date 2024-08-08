using System;
using System.Reflection;

namespace LibraryApp
{
    class Program
    {
        public static void Main()
        {
            Library MyLibrary = new Library();
            Book a_101 = new Book("Het kleine meisje van meneer Linh", "Philippe Claudel", 142, "Een oude man ontvlucht met zijn enkele weken oude kleindochter zijn door oorlog verscheurde land in Zuid-Oost Azie͏̈ om nieuw houvast te zoeken in een grote westerse stad.", "NL");
            MyLibrary.AddBook(a_101);
            MyLibrary.ViewBooksByAuthor("Philippe Claudel");
            MyLibrary.ViewBookByTitle("Het kleine meisje van meneer Linh");
            MyLibrary.InLibrary("blabla");
        }
        }
}
