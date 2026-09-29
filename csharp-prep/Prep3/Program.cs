using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Mail;

class Program
{

    static void Main(string[] args)
    {
        Random numgen = new Random();
        string userInput;
        int number = numgen.Next(1,100);
        int guess;
        string cont;

        Console.WriteLine("Welcome to the number guessing game! I'm going to generate a random number from 1-100 and you haveuserInput it!");
        do
        {
            Console.WriteLine("What is your guess? ");
            userInput = Console.ReadLine();
            guess = int.Parse(userInput);
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You got it!");
                do
                {
                    Console.WriteLine("Do you want to play again (yes/no) ");
                    cont = Console.ReadLine();
                } while (cont != "no");
            }
        } while (guess != number);
    }
}

/* Class Notes
List<int> numbers;

returnType FunctionName(datatype p1, datatype p2, ...)
{
    Code block
}
*/