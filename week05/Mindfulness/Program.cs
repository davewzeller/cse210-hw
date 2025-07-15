using System;
using System.Collections.Generic;
using System.Threading;


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Please choose an activity: ");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Please enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)

            {

                case "1":
                    BreathingActivity breathe = new BreathingActivity();
                    breathe.PerformActivity();
                    break;

                case "2":
                    ReflectingActivity reflect = new ReflectingActivity();
                    reflect.PerformActivity();
                    break;

                case "3":
                    ListingActivity list = new ListingActivity();
                    list.PerformActivity();
                    break;

                case "4":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("I didn't understand. Please try again.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}