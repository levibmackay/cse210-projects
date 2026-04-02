/*
This is the main file that runs the program. It creates a list of different activity objects,
including running, cycling, and swimming. Each one is added to the same list using the base
Activity type, which shows polymorphism in action. Then it loops through the list and calls
GetSummary on each object, which prints out the correct information depending on the activity
type. This keeps the program clean and flexible while using inheritance and method overriding.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2022", 30, 3.0));
        activities.Add(new Cycling("04 Nov 2022", 45, 12.0));
        activities.Add(new Swimming("05 Nov 2022", 40, 30));
        Console.WriteLine("");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine("");
    }
}