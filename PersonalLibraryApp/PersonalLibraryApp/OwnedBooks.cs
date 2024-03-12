using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibraryApp
{
    internal class OwnedBooks: Book
    {
      

        bool Owned {  get; set; }
        DateTime DateBought { get; set; }
        public OwnedBooks(string bookId, string title, string description, string authorLastName) : base(bookId, title, description, authorLastName)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorLastName = authorLastName;
        }

        public OwnedBooks(bool owned, DateTime dateBought)
        {
            Owned = owned;
            DateBought = dateBought;
        }
        public OwnedBooks(string bookId, string title, string description, string authorLastName, bool owned, DateTime dateBought) : base(bookId, title, description, authorLastName)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorLastName = authorLastName;
            Owned = owned;
            DateBought = dateBought;
        }

        public OwnedBooks()
        {
        }
    }
}
