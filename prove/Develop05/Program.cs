// EXCEEDING REQUIREMENTS
// I added a gamification system that includes levels and titles.
// As users earn points they level up and receive titles such as
// "Seeker" or "Disciple". The level system is also saved and loaded
// with the user's goals so progress is preserved between sessions.
// -Levi Mackay
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        // Menu Options
        // The score is tied to the file, so until they load a file/start a new one there won't be a score or nthg.
        bool running = true;

        while (running)
        {
            Console.WriteLine("");

            manager.DisplayScore();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                manager.CreateGoal();

            else if (choice == "2")
                manager.DisplayGoals();

            else if (choice == "3")
                manager.SaveGoals();

            else if (choice == "4")
                manager.LoadGoals();

            else if (choice == "5")
                manager.RecordEvent();
            else if (choice == "6")
                running = false;
        }
    }
}