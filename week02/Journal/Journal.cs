using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
public class Journal
{



    public static void AddEntry()
    {


        Entry.DisplayEntry();
        List<string> _entry = new List<string>();
        


    }

    public static void DisplayAll()

    {
       
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
            outputFile.WriteLine($" how are you today?");
        }
             
      


        return;
    }

    static public void LoadFromFile()
    {

        string bob;

        Console.WriteLine("What file do you want to Load? ");
        bob = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(bob);
        foreach (string line in lines)

        {
            string[] parts = line.Split(",");

            string hotwheels = parts[0];
            Console.WriteLine(hotwheels);
        }

        return;

    }


}
