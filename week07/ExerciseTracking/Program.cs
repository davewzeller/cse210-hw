using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2025", 30, 28),
            new Cycling("21 July 2025", 30, 183.9) 
   //         new Swimming("24 Aug 2025", 30, 20)


        };

        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        foreach (Activity a in activities)
        {

            Console.WriteLine(a.GetSummary());

        }    
    }
}