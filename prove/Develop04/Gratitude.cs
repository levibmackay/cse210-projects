using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity()
        : base("Gratitude Activity",
              "This activity helps you slow down and think about something specific you are grateful for and why it matters.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("\nThink of one thing you are genuinely grateful for.");
        ShowSpinner(5);

        Console.Write("\nWhy are you grateful for it? ");
        Console.ReadLine();

        Console.Write("\nHow does it impact your life? ");
        Console.ReadLine();

        Console.WriteLine("\nTake a few seconds to just sit with that.");
        ShowSpinner(GetDuration());
    }
}