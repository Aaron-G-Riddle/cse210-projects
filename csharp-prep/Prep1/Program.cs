using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;
        Console.Write("Please enter first your name: ");
        firstName = Console.ReadLine();
        Console.Write("Please enter last your name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"{firstName} {lastName}");
        
    }
}