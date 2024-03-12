using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibraryApp
{
    internal class WishList: Book
    {
        

        double Price {  get; set; }
        public WishList(string bookId, string title, string description, string authorLastName) : base(bookId, title, description, authorLastName)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorLastName = authorLastName;
        }
        public WishList(double price)
        {
            Price = price;
        }
        public WishList(string bookId, string title, string description, string authorLastName,double price) : base(bookId, title, description, authorLastName)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorLastName = authorLastName;
            Price = price;
        }
        public WishList()
        {
        }

        
    }
}
