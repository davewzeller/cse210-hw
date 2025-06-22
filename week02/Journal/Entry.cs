using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text;
public class Entry
{
    public string _date;
    public string _entryText;


    public string _entries;

    public static string DisplayEntry()
    {
        DateTime now = DateTime.Now;


        string _date = now.ToString("MMMM dd, yyyy");

        Console.WriteLine($"{_date}");
        string _prompt = PromptGenerator._prompt();
        
        string _entryText = Console.ReadLine();

        StringBuilder SB = new StringBuilder();
        SB.Append($"{_date}");
        SB.Append($" {_prompt}");
        SB.Append($": {_entryText}");

        string result = SB.ToString();

        Console.WriteLine(result);
        return result;
    }
}