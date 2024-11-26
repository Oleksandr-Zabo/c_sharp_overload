using c_sharp_overload.Entity;
using System;
namespace c_sharp_overload
{
    
    internal class Program
    {//ex. 2
        static void Main()
        {
            Shop shop = new Shop(name: "Boots", 
                address:"Ukraine, Kyiv", description: "Sale boots", 
                contact_number: "+380674375287", email: "email@shop.com",
                square: 12.1);
            Console.WriteLine(shop);

            Console.WriteLine();
            shop += 10;
            Console.WriteLine(shop);

            Console.WriteLine();
            shop -= 5;
            Console.WriteLine();
            Console.WriteLine(shop);
            Console.WriteLine();
            Console.WriteLine($"Is square equal 17.1 {shop == 17.1}");
            Console.WriteLine($"Is square > 17 {shop > 17}");
            Console.WriteLine($"Is square < 17 {shop < 17}");
        }
    }
}
