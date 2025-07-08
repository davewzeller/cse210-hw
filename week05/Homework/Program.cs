using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment1 = new Assignment("Bob Pope", "Funny people");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment assignment2 = new MathAssignment("Bob Saget", "Fractions", "pg 135-138", "5-100");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeWorkList());
        Console.WriteLine();

        WritingAssignment assignment3 = new WritingAssignment("Cinder Zeller", "Short Story Writing", "Have you ever gone a fishing");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
        Console.WriteLine();
    }


}
