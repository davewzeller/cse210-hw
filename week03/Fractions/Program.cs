using System;

class Program
{
    static void Main(string[] args)
    {


        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.getDesimal());

        Fraction F2 = new Fraction(5);
        Console.WriteLine(F2.GetFractionString());
        Console.WriteLine(F2.getDesimal());

        Fraction F3 = new Fraction(3, 4);
        Console.WriteLine(F3.GetFractionString());
        Console.WriteLine(F3.getDesimal());

        Fraction F4 = new Fraction(1, 3);
        Console.WriteLine(F4.GetFractionString());
        Console.WriteLine(F4.getDesimal());

    }
    








}




