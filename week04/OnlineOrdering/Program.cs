using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("742 Evergreen Terrace", "SpringField", "Oregon 97403", "USA");
        Customer customer = new Customer("Homer Simpson", address1);

        Product p1 = new Product("Root-Beer", "049000023923", 4.95, 3);
        Product p2 = new Product("Pink Doughnut", "043200928712", .89, 12);
    }
}