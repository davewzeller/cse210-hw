using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Runtime.ExceptionServices;


public class Journal
{

    private static List<string> entries = new List<string>();

    public static void AddEntry()
    {

        string entry = Entry.DisplayEntry();
        entries.Add(entry);

        //Entry.DisplayEntry();
        //List<string> _entry = new List<string>();

        //Console.WriteLine(result);
        


    }

    public static void DisplayAll()

    {
        foreach (string entry in entries) 
        {
            Console.WriteLine(entry);
        }

        Console.WriteLine("Display");
        return;
    }

    public static void SaveToFile()
    {
        string _mytext;

        Console.WriteLine("What file do you want to save to? ");
        _mytext = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_mytext))
        {
            foreach (string entry in entries)
            {

                outputFile.WriteLine(entry);


            }
            outputFile.WriteLine($" how are you today?");
        }


        Console.WriteLine("I hope this works. ");

        //return;
    }

    static public void LoadFromFile()
    {

        Console.WriteLine("what file do you want to read? ");
        string bob = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(bob);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string date = parts[0];

            Console.WriteLine(date);

        }



    }


}
