using System.Reflection.Metadata;

public class Reference

{

    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
        //Console.WriteLine($"{_book} + {_chapter} + { _verse}");
        // Console.WriteLine("bob was her");
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)

    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        Console.Write("bob is the full verse");
    }

    public override string ToString()
    {
        return _endVerse.HasValue
                ? $"{_book} {_chapter}:{_verse}-{_endVerse.Value}"
                : $"{_book} {_chapter}:{_verse}";
    }

}
