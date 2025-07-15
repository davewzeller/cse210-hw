using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private static readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing", "This activity helps you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void PerformActivity()
    {
        do
        {
            DisplayStart();

            Console.WriteLine(prompts[new Random().Next(prompts.Length)]);
            Console.WriteLine("You’ll have a few seconds to think, then start listing.");
            ShowCountDown(5);

            int duration = GetDuration();
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            List<string> items = new List<string>();

            while (DateTime.Now < endTime)
            {
                Console.Write(">");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                    items.Add(input);
            }

            Console.WriteLine($"You listed {items.Count} items!");
            DisplayEnd();

            Console.WriteLine("Would you like to repeat the Listing activity? (yes/no)");
        }
        while (Console.ReadLine()?.Trim().ToLower() == "yes");
    }

}
