using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your magic number? ");
        // string magicNumber = Console.ReadLine();
        // int magic = int.Parse(magicNumber);
        // I have a hard time with loops!


        //Console.WriteLine();
        // Console.Write("What is your Guess? ");

        // string Number = Console.ReadLine();
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);

        int number = 65;

        while (number != magic)
        {
            Console.Write("What is your Guess? ");
            string Number = Console.ReadLine();
            number = int.Parse(Number);



            if (magic > number)
            {
                Console.WriteLine("Higher");
                
            }
            else if (magic < number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    //    Console.WriteLine($" {magic} and {number}");
    }
}