using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string letter = "F";
        string failed = "you failed, but you will get it next time.";
        string pass = "you passed good job!";

        Console.Write("What is you grade percentage? ");
        string percentage = Console.ReadLine();

        int number = int.Parse(percentage);


        if (number >= 90)
        {
            letter = "A";
        }

        else if (number >= 80)
        {
            letter = "B";
        }

        else if (number >= 70)
        {
            letter = "C";
        }

        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            Console.Write(" ");
        }

        Console.Write($"Your grade is an {letter}, ");
        if (number >= 70)
        {
            Console.WriteLine(pass);
        }
        else
        {
            Console.WriteLine(failed);
        }
        //  Console.WriteLine();
        //  Console.Write($"Same  {letter} {number} {failed}");
    }
}