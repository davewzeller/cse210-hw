using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        string bookName = "Proverbs";
        int chapter = 3;
        int startVerse = 5;
        int endVerse = 6;

        Reference reference = new Reference(bookName, chapter, startVerse, endVerse);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";

        Scripture scripture = new Scripture(reference, text);
        const int WordsToHideEachRound = 3;

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are now hidden. Press any key to quit.");
                Console.ReadKey();
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to quit.");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit")
                break;

            scripture.HideRandomWords(WordsToHideEachRound);
        }

        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
    }
}