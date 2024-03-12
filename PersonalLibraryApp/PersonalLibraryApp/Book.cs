using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibraryApp
{
    internal class Book
    {
        

        public String BookId { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String AuthorLastName { get; set; }

        public Book(string bookId, string title, string description, string authorLastName)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorLastName = authorLastName;
        }
        public Book() { }
        public virtual string Print()
        {
            return "BookId: " + BookId + "\nTitle: " +Title + "\nDescription:" + Description + "\nAuthor Name" + AuthorLastName;
        }
    }
}
