using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();



        //      Console.Write("Enter number: ");
        //      string enteredN = Console.ReadLine();
        //      int numberAdd = int.Parse(enteredN);
        int numberAdd = 1;

        while (numberAdd != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            Console.Write("Enter number: ");
            string enteredN = Console.ReadLine();


            numberAdd = int.Parse(enteredN);
            number.Add(numberAdd);
            number.Remove(0);

      }


        int sum = number.Sum();
        Console.WriteLine($"The Sum is {sum}");


        double average = number.Average();
        Console.WriteLine($"The average is: {average}");

        int max = number.Max();
        Console.WriteLine($"The largest number is: {max}");
    }
    
}