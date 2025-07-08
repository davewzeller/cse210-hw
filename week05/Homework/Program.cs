using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment1 = new Assignment("bob sagget", "funny people");
        assignment1.GetSummary();

        MathAssignment assignment2 = new MathAssignment("Bob Saggett", "Fractions", "pg 135-138", "5-100");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeWorkList());
    }
}
