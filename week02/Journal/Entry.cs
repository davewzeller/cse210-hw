using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
public class Entry
{
    string _date;



    //public string _entries;

    public static void DisplayEntry()
    {
        DateTime now = DateTime.Now;

        
        string _date = now.ToString("MMMM dd, yyyy");

        Console.WriteLine($"{_date}");
      
    }
}