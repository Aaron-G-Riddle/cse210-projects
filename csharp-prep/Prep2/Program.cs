using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage in one of your classes? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter;
        string lead;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade >= 90)
        {
            lead = "an";
        }
        else
        {
            lead = "a";
        }

        int range = grade % 10;
        string sign;

        if (range >= 7 && grade >= 95)
        {
            sign = "";
        }
        else if (range >= 7 && grade < 60 || range <= 3 && grade < 60)
        {
            sign = "";
        }
        else if (range >= 7)
        {
            sign = "+";
        }
        else if (range <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Since you have {grade}% in your class, you have {lead} {letter}{sign}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats! Your grade is higher than 70%, so you passed the class!");
        }
        else
        {
            Console.WriteLine("Since your grade is below 70% you didn't pass the class. You'll get it next time!");
        }
    }
}