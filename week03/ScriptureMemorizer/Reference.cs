using System.Reflection.Metadata;

public class Reference

{

    public string _book;
    public int _chapter;

    public int _verse;

    public int _endVerse;


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        Console.WriteLine($"{_book} + {_chapter} + { _verse}");
        Console.WriteLine("bob was her");
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)

    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        Console.Write("bob is the full verse");
    }
}
