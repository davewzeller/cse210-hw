using System;

class Program
{
    static void Main(string[] args)
    {
        Reference _reference = new Reference("Proverbs", 3,5 );

        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(_reference, text);


        Scripture.HideRandomWords(3);
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
    }
}