using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int choice = menu.DisplayMenu();
        while (choice != 4)
        {
            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunActivity();
            }
            else if (choice == 2)
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.RunActivity();
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.RunActivity();
            }
        }
    }
}