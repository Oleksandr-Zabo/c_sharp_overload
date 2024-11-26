using c_sharp_class_1.Entity;

namespace c_sharp_overload
{
    internal class Program
    {//ex. 1
        static void Main()
        {
            var journal = new Journal(name: "Journal", year: 2021, description: "Description",
               ip_address: "191.19.00.01", email: "email@dot.com", 
               num_workers:5);
            Console.WriteLine(journal);

            Console.WriteLine();
            journal += 3;
            Console.WriteLine(journal);

            Console.WriteLine();
            journal -= 4;
            Console.WriteLine($"Is number of workers egual 4: {journal == 4}");
            Console.WriteLine($"Is number of workers > 2: {journal > 2}");
            Console.WriteLine($"Is number of workers < 3: {journal < 3}");

        }
    }
}
