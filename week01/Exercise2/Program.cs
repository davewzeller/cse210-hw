using System;

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
            Console.Write($"Your grade is an {letter} ");
            Console.WriteLine(pass);
        }

        else if (number >= 80)
        {
            letter = "B";
            Console.Write($"Your Grade is a {letter} "); ;
        }

        else if (number >= 70)
        {
            letter = "C";
            Console.Write($"Your Grade is a {letter} "); ;
        }

        else if (number >= 60)
        {
            letter = "D";
            Console.Write($"Your Grade is a {letter} ");
            Console.WriteLine(failed);
        }
        else
        {

            Console.Write($"Your Grade is an {letter} "); ;
            Console.WriteLine(failed);
        }
      //  Console.WriteLine();
      //  Console.Write($"Same  {letter} {number} {failed}");
    }
}