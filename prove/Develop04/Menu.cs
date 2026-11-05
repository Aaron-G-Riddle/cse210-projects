class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("Welcome to the Mindfulness Program.");
        Thread.Sleep(2000);
        Console.Write("\b");
        Console.WriteLine(
            """
            What activity would you like do?
            1 - Breathing
            2 - Reflection
            3 - Listing
            4 - Quit
            Please answer with 1 - 4.
            """
        );
        string choice = Console.ReadLine();
        int activity = int.Parse(choice);
        return activity;
    }
}