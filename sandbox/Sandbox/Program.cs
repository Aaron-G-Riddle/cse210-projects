using System;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    // Functions (inside class outside of Main)
    // static double AddNumbers(double x, int y)
    // {
    //     return x + y;
    // }

    // static string MyName()
    // {
    //     return "Bob";
    // }

    // static void DisplayGreeting(string name)
    // {
    //     Console.WriteLine($"Welcome {name}, it's nice to meet you.");
    // }

    static void Main(string[] args)
    {
        Circle myCircle = new Circle();

        myCircle._radius = 10;

        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }
}
        // Calling Functions

        // string myName = MyName();
        // DisplayGreeting(myName);
        // double total = AddNumbers(12.234, 20);
        // Console.WriteLine(total);

        // Console.WriteLine("Bonjour tout le monde.");
        // Console.WriteLine("Hello Jude!");

        // While Loops

        // bool done = false;

        // while (! done)
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine() == "y";
        // }
        
        // bool done;

        // do
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine().ToLower() == "y";
        // } while (! done);

        // For loop

        // for(int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // Lists List<int> = new List<int>()

        // List<string> myFriends = new List<string> {"Bob", "Betty", "Bubba"};

        // myFriends.Add("Doug");

        // foreach(string friend in myFriends)
        // {
        //    Console.WriteLine(friend);
        // }