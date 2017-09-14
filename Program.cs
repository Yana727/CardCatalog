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

        var titleSeach = library.searchByTitle("Treasure"); 
        foreach (var item in titleSeach)
        {
            Console.WriteLine ("Searching for the title");
            Console.WriteLine ($"{item.BookName} is written by {item.Author}"); 
        }

        var authorItem = library.searchByAuthor("Billy");
        Console.Write ($"{authorItem.Author} wrote {authorItem.BookName}"); 


        var isla = new Member
        {
            Name = "Isla",
            Address = "123 Abc Rd", 
            PhoneNumber = "123-456-7890", 
            Email = "awesome@dog.com"
        }; 

        var overdueSearchList = library.searchForOverdue();
        foreach (var item in overdueSearchList)
        {
           Console.WriteLine($"{item.BookName} is overdue");
        }
        library.CheckOut ("Treasure", "Isla");
        library.CheckOut ("Norwitch", "Isla"); 
        library.CheckInBook ("Treasure","Isla"); 
        }
    }
}
