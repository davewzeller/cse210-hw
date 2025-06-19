using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");


        string _entries = Console.ReadLine();
        // int _entries = int.Parse(Number);


        // Console.WriteLine($"Hi {_entries}");

        if (_entries == "1")
        {
            Journal.AddEntry();

        }
        else if (_entries == "2")
        {
            Journal.DisplayAll();
        }
        else if (_entries == "3")
        {

            Journal.LoadFromFile();
        }
        else if (_entries == "4")
        {
           Journal.SaveToFile();
        }
        else 
        {
            Console.WriteLine("quit");
        }
       // else
       // {
       //     Console.WriteLine("Try again");
       //     _entries = Console.ReadLine();
       // }
    }
}