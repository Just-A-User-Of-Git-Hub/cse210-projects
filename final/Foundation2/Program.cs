using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(
            [
                new Product("Apple", 108934, 1, 10),
                new Product("Orange", 108349, 1.5f, 3),
                new Product("Banana", 107908, 0.25f, 15)
            ],
            new Customer(
                "John Jacob Jingleheimer Schmidt",
                new Address("1705 Live Oak Street","Denver","Colorado","United States")
            )
        );
        Order order2 = new Order(
            [
                new Product("Pillow", 390013, 20, 2),
                new Product("Mattress", 390005, 1200, 1),
                new Product("Jar of Peanuts", 134944, 7.30f, 20)
            ],
            new Customer(
                "Taylor Neilson",
                new Address("2 Claxton Avenue","Manchester","","United Kingdom")
            )
        );
        Order order3 = new Order(
            [
                new Product("Barbecue Lays", 167880, 4.89f, 1000),
                new Product("Small plate", 500010, 10.25f, 3),
                new Product("Backpack", 765432, 35, 1)
            ],
            new Customer(
                "Maggie Ruston",
                new Address("600 Maggie Drive","Ruston","Louisiana","United States")
            )
        );

        Console.WriteLine($"Order1 packing label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"\nOrder1 shipping label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"\nOrder1 total price:\n{order1.GetTotalPrice()}");

        Console.WriteLine($"\nOrder2 packing label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"\nOrder2 shipping label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"\nOrder2 total price:\n{order2.GetTotalPrice()}");

        Console.WriteLine($"\nOrder3 packing label:\n{order3.GetPackingLabel()}");
        Console.WriteLine($"\nOrder3 shipping label:\n{order3.GetShippingLabel()}");
        Console.WriteLine($"\nOrder3 total price:\n{order3.GetTotalPrice()}");
    }
}