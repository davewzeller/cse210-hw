using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("742 Evergreen Terrace", "SpringField", "Oregon 97403", "USA");
        Customer customer = new Customer("Homer Simpson", address1);
    }
}