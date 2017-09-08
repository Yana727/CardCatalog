using System;

namespace Catalog
{
    public class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public bool IsCheckedOut {get; set;}
        public DateTime PublishedDate { get; set; }
        public DateTime Overdue { get; set; }

        public Book(){} 

    }
}
