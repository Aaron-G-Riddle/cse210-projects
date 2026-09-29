using System;
using System.Xml.Schema;

class Program
{
    static void DisplayGreeting()
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
        string input = Console.ReadLine();
        int num = int.Parse(input);
        return num;
    }

    static int PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        string input = Console.ReadLine();
        int year = int.Parse(input);
        return year;
    }

    static int SquareNumber(int num)
    {
        int sqaured = num * num;
        return sqaured;
    }

    static void DisplayResults(string name, int snum, int year)
    {
        Console.WriteLine($"{name}, the sqaure of your number is: {snum}");
        int age = 2026 - year;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }

    static void Main(string[] args)
    {
        DisplayGreeting();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int year = PromptUserBirthYear();
        int sqaured = SquareNumber(num);
        DisplayResults(name, sqaured, year);
    }
}