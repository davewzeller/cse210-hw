using System;
using System.Collections.Generic;
using System.Threading;

public class Activity

{

    private string _name;
    private string _description;
    private int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void DisplayStart()
    {

        Console.Clear();
        Console.WriteLine($"Starting {_name} Activity...");
        Console.WriteLine(_description);
        Console.WriteLine("Enter the Duration in seconds: ");
        _duration = int.Parse(Console.ReadLine() ?? "60");
        Console.WriteLine("Get ready to Start ");
        ShowSpinner(3);
    }


    public void DisplayEnd()
    {
        Console.WriteLine("Good Job!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected int GetDuration() => _duration;

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);

        }
        Console.WriteLine();
    }

}