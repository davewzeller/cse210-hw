using System;
using System.Collections.Generic;
using System.Threading;


public class ReflectingActivity : Activity
{
    private static readonly string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
        : base("Reflection", "This activity will help you reflect on times in your life when you've shown strength and resilience.")
    {
    }

    public void PerformActivity()
    {
        do
        {
            DisplayStart();

            Console.WriteLine(prompts[new Random().Next(prompts.Length)]);
            Console.WriteLine();

            int duration = GetDuration();
            int elapsed = 0;

            while (elapsed < duration)
            {
                string question = questions[new Random().Next(questions.Length)];
                Console.WriteLine(question);
                ShowSpinner(4);
                elapsed += 4;
            }

            DisplayEnd();

            Console.WriteLine("Would you like to repeat the Reflection activity? (yes/no)");
        }
        while (Console.ReadLine()?.Trim().ToLower() == "yes");
    }

}
