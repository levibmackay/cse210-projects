using System;
using System.Collections.Generic;

/*
HOW I WENT ABOVE AND BEYOND:

To make this better than just the base requirements, I added a few extra things.

First, I created a fourth activity called GratitudeActivity. The assignment only
required three, but I wanted to add another structured option that still fits
the mindfulness theme.

Second, I made the program track how many total activities the user completes
during one session and display that number when they quit. It makes it feel
a little more real instead of just running activities with no feedback.

Third, I was careful to keep all shared logic (starting message, ending message,
duration, spinner animation, countdown, etc.) inside the base Activity class.
That way there’s no duplicated code and the inheritance structure actually
makes sense.

Overall I tried to keep the design clean, simple, and objectoriented without
overcomplicating anything.
*/



class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        int totalActivitiesCompleted = 0;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1")
                activity = new BreathingActivity();
            else if (choice == "2")
                activity = new ReflectionActivity();
            else if (choice == "3")
                activity = new ListingActivity();
            else if (choice == "4")
                activity = new GratitudeActivity();
            else if (choice == "5")
                running = false;

            if (activity != null)
            {
                activity.Run();
                totalActivitiesCompleted++;
            }
        }

        Console.WriteLine($"\nYou completed {totalActivitiesCompleted} activities this session. Solid work.");
        Console.WriteLine("Thanks for using the Mindfulness Program.");
    }
}