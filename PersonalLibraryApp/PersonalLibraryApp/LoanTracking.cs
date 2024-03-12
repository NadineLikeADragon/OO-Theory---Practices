using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibraryApp
{
    internal class LoanTracking:Book
    {
        DateTime DateBorrowed {  get; set; }
        DateTime DueDate { get; set; }
         public LoanTracking(string bookId, string title, string description, string authorLastName) : base(bookId, title, description, authorLastName)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorLastName = authorLastName;
        }

        public LoanTracking(DateTime dateBorrowed, DateTime dueDate)
        {
            DateBorrowed = dateBorrowed;
            DueDate = dueDate;
        }
        public LoanTracking(string bookId, string title, string description, string authorLastName, DateTime dateBorrowed, DateTime dueDate) : base(bookId, title, description, authorLastName)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorLastName = authorLastName;
            DateBorrowed = dateBorrowed;
            DueDate = dueDate;
        }
        public LoanTracking()
        {
        }
    }
}
