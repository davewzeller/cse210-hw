using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
public class Scripture
{
    public static Reference _reference;
    private List<Word> Words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        Words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
        Console.WriteLine("Cinder is driving me crazy");
    }

    public void HideRandomWords(int numberToHide)
    {
        var rand = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = rand.Next(Words.Count);
            Words[index].Hide();        
        }
            Console.WriteLine("Cinder is blocking the monitor");
    
    }

    public void GetDisplayText(string text)

    {
        Console.WriteLine("Cinder is blocking the monitor");
        Console.WriteLine(_reference.ToString());
        foreach (var word in Words)
        {
            Console.Write(word.GetDisplayText() + " ");

        }
        Console.WriteLine(); 
     
    }
}