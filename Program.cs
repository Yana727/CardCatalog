using System;
using System.Collections.Generic;
using Catalog;

namespace CardCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
        var library = new Library();
        var book1 = new Book
        {
            BookName = "Norwitch", 
            Author = "Bokk Bryson",
            PublishDate = new DateTime(2008,1,1), 
            IsCheckedOut = false, 
        }; 
        var book2 = new Book
        {
            BookName = "Treasure",
            Author = "Billy",
            PublishDate = new DateTime (2010,9,2),
            IsCheckedOut = true,
        }; 
        library.Catalog.Add(book1); 
        library.Catalog.Add(book2); 

        }
    }
}
