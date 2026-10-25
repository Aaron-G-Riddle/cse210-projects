using System;
using System.Net;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        string response = "";

        Scripture myScripture = new Scripture("Moses", 1, 39, 
            "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
        myScripture.ShowScripture();
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        response = Console.ReadLine();

        do
        {
            if (response != "quit")
            {
                Console.Clear();

                myScripture.HideRandomWords();

                myScripture.ShowScripture();

                if (myScripture.IsCompletelyHidden() == true)
                {
                    response = "quit";
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                    response = Console.ReadLine();
                }
            }

        } while (response != "quit");
    }
}