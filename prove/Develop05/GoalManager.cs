using System;
using System.Collections.Generic;
using System.IO;

// The abosilute WORK HORSE of this program.
// Prety much everything comes through this guy
// Loads, Saves, displays goals, records events and gets a title base d on the user and the level.
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times doesn this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write($"What is the bonus for accomplishing it {target} times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    // Loop through the list and display each goal with its progress
    // This took me a long time to figure out and I don't understand it still completely
    public void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int pointsEarned = _goals[index].RecordEvent();

        _score += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points!");

        if (_score >= _level * 1000)
        {
            _level++;
            Console.WriteLine($"🎉 LEVEL UP! You are now Level {_level}!");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine($"{_score},{_level}");

            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
            return;

        _goals.Clear();

        string[] lines = File.ReadAllLines("goals.txt");

        // This is where the Points and the Level is separated. I have them saved on the same line in the file, so I did this to separate it
        string[] header = lines[0].Split(",");
        _score = int.Parse(header[0]);
        _level = int.Parse(header[1]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            string[] parts = line.Split(":");

            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    int.Parse(data[3]),
                    int.Parse(data[4])
                ));
            }
        }

        Console.WriteLine("Goals loaded.");
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {_score} | Level: {_level} | Title: {GetTitle()}");
    }
    public string GetTitle()
    {
        if (_score >= 15000) return "Eternal Champion";
        if (_score >= 7000) return "Master";
        if (_score >= 3000) return "Disciple";
        if (_score >= 1000) return "Seeker";
        return "Beginner";
    }
}