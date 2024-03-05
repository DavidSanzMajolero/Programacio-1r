using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activitats
{
    public class Book : IComparable<Book>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int NumPages { get; set; }
        public Book(int id, string title, int numPages)
        {
            Id = id;
            Title = title;
            NumPages = numPages;
        }
  
        public Book(): this(0, "Unknown", 0)
        {
            Id = 0;
            Title = "Unknown";
            NumPages = 0;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, NumPages: {NumPages}";
        }

        public int CompareTo(Book? other)
        {
            if (other == null) return 1;
            return this.NumPages.CompareTo(other.NumPages);
        }

    }
}
