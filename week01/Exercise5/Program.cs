using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
   // string who = "bob";
    

    static void Main(string[] args)
    {


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string favorite = Console.ReadLine();
            int fnumber = int.Parse(favorite);

            return fnumber;
        }

        static int SquareNumber(int fnumber) {
           
            int squareNumber = fnumber * fnumber;
            return squareNumber;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
           // return void;
        }

        DisplayWelcome();
        string name = PromptUserName();
        int fnumber = PromptUserNumber();
        int number = SquareNumber(fnumber);
        DisplayResult(name, number);


      //  Console.Write($"{name} + {number}");

    }
}