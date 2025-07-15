using System;
using System.Collections.Generic;
using System.Threading;


public class BreathingActivity : Activity

{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. ")
    {

    }

    public void PerformActivity()
    {
        do
        {
            DisplayStart();

            int duration = GetDuration();
            int cycleTime = 6;
            int elapsed = 0;

            while (elapsed < duration)
            {
                Console.WriteLine("Breathe in ... ");
                ShowCountDown(3);

                Console.WriteLine("Breathe out ...");
                ShowCountDown(3);

                elapsed += cycleTime;
            }

            DisplayEnd();

            Console.WriteLine("Would you like to repeat the Breathing activity? (yes/no)");
        }
        while (Console.ReadLine()?.Trim().ToLower() == "yes");
    }

}
