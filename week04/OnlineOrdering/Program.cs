using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("742 Evergreen Terrace", "SpringField", "Oregon 97403", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);

        Product p1 = new Product("Root-Beer", "049000023923", 4.95, 3);
        Product p2 = new Product("Pink Doughnut", "043200928712", .89, 12);



        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n\n");


        Address address2 = new Address("Cantacuzio Castle", "Palatul Monteoru", "Bucharest 010001", "Romania");
        Customer customer2 = new Customer("Wednesday Addams", address2);

        Product p3 = new Product("Switch Blade", "4AKQXIXT", 13.99, 1);
        Product p4 =  new Product("Emergency Laceration Closures", "CLOZEXINC", 34.99, 1);
        Product p5 = new Product("Sward", "DAGGERBLUNT", 28.07, 1);
        Product p6 = new Product("Miniature Violin", "DSELVGUARTS", 11.99, 1);



        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);
        order2.AddProduct(p5);
        order2.AddProduct(p6);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}\n\n");
    }

}