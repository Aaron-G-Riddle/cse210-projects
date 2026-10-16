using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Console.WriteLine(frac1.GetFraction());
        Console.WriteLine(frac1.GetDec());

        Fraction frac2 = new Fraction(5);
        Console.WriteLine(frac2.GetFraction());
        Console.WriteLine(frac2.GetDec());

        Fraction frac3 = new Fraction(3,4);
        Console.WriteLine(frac3.GetFraction());
        Console.WriteLine(frac3.GetDec());

        Fraction frac4 = new Fraction(1,3);
        Console.WriteLine(frac4.GetFraction());
        Console.WriteLine(frac4.GetDec());

        Random random = new Random();
        Fraction frac5 = new Fraction();
        for (int i = 0; i < 20; i++)
        {
            int numVal = random.Next(1,11);
            int denVal = random.Next(1,11);
            frac5.SetNum(numVal);
            frac5.SetDen(denVal);
            Console.WriteLine($"Fraction {i + 1}: ");
            Console.WriteLine($"String: {frac5.GetFraction()}");
            Console.WriteLine($"Decimal: {frac5.GetDec()}");
            Console.WriteLine();
        }                
    }
}