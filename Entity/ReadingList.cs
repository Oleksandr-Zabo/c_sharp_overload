using System;

namespace c_sharp_overload.Entity
{
    internal class ReadingList
    {

        private Book[] books = new Book[0];

        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
        public static ReadingList operator +(ReadingList rList, Book book)
        {
            if (!ContainsBook(rList, book))
            {
                Array.Resize(ref rList.books, rList.books.Length + 1);
                rList.books[rList.books.Length - 1] = book;
                Console.WriteLine($"Added: {book}");
            }
            else
            {
                Console.WriteLine($"The book '{book}' is already in the list.");
            }
            return rList;
        }
        public static ReadingList operator -(ReadingList rList, Book book) {
            if (ContainsBook(rList, book))
            {
                int index = Array.IndexOf(rList.books, book);
                if (index >= 0)
                {
                    for (int i = index; i < rList.books.Length - 1; i++)
                    {
                        rList.books[i] = rList.books[i + 1];
                    }
                    Array.Resize(ref rList.books, rList.books.Length - 1);
                    Console.WriteLine($"Removed: {book}");
                }
            }
            else
            {
                Console.WriteLine($"The book '{book}' is not in the list.");
            }
            return rList;
        }


        public static bool ContainsBook(ReadingList rList, Book book)
        {
            foreach (var b in rList.books)
            {
                if (b == book)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ContainsBook( Book book)
        {
            foreach (var b in books)
            {
                if (b == book)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string booksString = "Books in your reading list:";
            for (int i = 0; i < books.Length; i++) {
                booksString += this[i] + "\n";
            }
            return booksString;
        }
    }
}