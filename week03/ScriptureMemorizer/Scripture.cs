using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
public class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;
    private readonly Random _random = new Random();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;


        _words = text
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(w => new Word(w))
            .ToList();

    }
    public void Display()

    {
        {
            Console.WriteLine(_reference);
            Console.WriteLine(string.Join(" ",
                _words.Select(w => w.GetDisplayText())));
        }

    }
    public bool AllWordsHidden() => _words.All(w => w.IsHidden);

    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

}