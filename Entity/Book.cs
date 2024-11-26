using System;

namespace c_sharp_overload.Entity
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public static bool operator ==(Book b1, Book b2)
        {
            return b1.Title == b2.Title && b1.Author == b2.Author;
        }

        public static bool operator !=(Book b1, Book b2)
        {
            return !(b1 == b2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Book book)
            {
                return this == book;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Author);
        }

        public override string ToString()
        {
            return $"{Title} by {Author}";
        }
    }
}
