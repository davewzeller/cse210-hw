using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
class Program
{

    static void Main(string[] args)


    {

        bool running = true;
        while (running)

        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();

            // int test = 0;
            string _entries = Console.ReadLine();
            // int _entries = int.Parse(Number);
            //test = int.Parse(_entries);




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
            else if (_entries == "5")
            {

                Console.WriteLine("quit");
                running = false;
                break;

            }


            //  {
            // Console.WriteLine("Try again");

            //   }
            //  Console.WriteLine("WHAT WOULD YOU DO ");
            //  _entries = Console.ReadLine();

        }
    }
}