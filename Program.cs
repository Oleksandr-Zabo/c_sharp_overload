namespace c_sharp_overload
{
    using c_sharp_overload.Entity;
    internal class Program
    {//ex-3
        static void Main()
        {
            ReadingList readingList = new ReadingList();

            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");

            readingList += book1;
            Console.WriteLine();
            readingList += book2;
            Console.WriteLine();

            Console.WriteLine(readingList);
            
            Console.WriteLine($"Contains '1984': {readingList.ContainsBook(book1)}");

            Console.WriteLine();
            Console.WriteLine(readingList);
            Console.WriteLine($"Book index 1: {readingList[1]}");

            readingList -= book1;
            Console.WriteLine();
            Console.WriteLine(readingList);
        }
    }
}
