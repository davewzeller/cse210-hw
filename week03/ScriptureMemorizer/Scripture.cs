using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
public class Scripture
{
    private  Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;


        _words = text
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(w => new Word(w))
            .ToList();
            
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden);


    }

    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int idx = _random.Next(_words.Count);
            _words[idx].Hide();
        }
    }

    public void Display()

    {
        {
            Console.WriteLine(_reference);
            Console.WriteLine(string.Join(" ",
                _words.Select(w => w.GetDisplayText())));
        }

    }
}