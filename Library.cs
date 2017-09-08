using System;
using System.Collections.Generic;
using System.Linq;

namespace Catalog
{
    public class Library 
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Book> Catalog = new List<Book>();

        public IEnumerable<Book> searchByTitle(string BookName)
        {
            var title = Catalog.Where(w => w.BookName.ToLower().Contains(BookName.ToLower())); 
            return title; 
        }

        public Book searchByAuthor (string Author)
        {
            var author = Catalog.FirstOrDefault (first => first.Author == Author);
            return author; 
        }
        public IEnumerable<Book> searchForOverdue()
        {
            var IsOverdue = Catalog.Where(w => w.Overdue <= DateTime.Now); 
            return IsOverdue; 
        }
        public void CheckOut (string BookName, string Name)
        {
            var CheckOut = Catalog.FirstOrDefault (f => f.BookName == BookName);
            if(CheckOut?.IsCheckedOut == true)
            {
                Console.WriteLine("The book is checked out"); 
            } else{
                Console.WriteLine ("The book is available"); 
                CheckOut.IsCheckedOut = true; 
            }
        }
        public void CheckInBook (string BookName, string Name)
        {
            var CheckOut = Catalog.FirstOrDefault(f => f.BookName == BookName); 
            if (CheckOut?.IsCheckedOut == false)
            {
                Console.WriteLine("This book is checked in");
            } else{
                Console.WriteLine ("Book is now checked in"); 
            }
        }
        
    }
}