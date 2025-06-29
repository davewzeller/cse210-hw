using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
public class PromptGenerator

{


    public static string _prompt()
    {
        List<string> _prompt = new List<string>();

        _prompt.Add("Today I found joy in: ");
        _prompt.Add("Things I did for myself: ");
        _prompt.Add("Things I did for Others: ");
        _prompt.Add("Today I am grateful for: ");
        _prompt.Add("Inspiring words for today: ");
        _prompt.Add("Things to let go of today: ");


        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(0, _prompt.Count);
        // thank goodness for my brother in law. 

        //Console.WriteLine($"{magic}");
        Console.Write($"{_prompt[magic]}");
        return _prompt[magic];
        
    }





/*    public int GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 5);



        return magic;
    }
*/    
}
