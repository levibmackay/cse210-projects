using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        bool running = true;

        while (running)
        {
            Console.WriteLine("");

            manager.DisplayScore();

            
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                manager.CreateGoal();

            else if (choice == "2")
                manager.DisplayGoals();

            else if (choice == "3")
                manager.RecordEvent();

            else if (choice == "4")
                manager.SaveGoals();

            else if (choice == "5")
                manager.LoadGoals();

            else if (choice == "6")
                running = false;
        }
    }
}