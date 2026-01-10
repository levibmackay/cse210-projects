using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Percentage: ");
        string response = Console.ReadLine();
        int percent = int.Parse(response);

        string letterGrade = "";
        string sign = "";

        if (percent >= 90)
        {
            letterGrade = "A";
        }
        else if (percent >= 80)
        {
            letterGrade = "B";
        }
        else if (percent >= 70)
        {
            letterGrade = "C";
        }
        else if (percent >= 60)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }

        int lastDigit = percent % 10;

        if (letterGrade != "A" && letterGrade != "F")
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit <= 2)
                sign = "-";
        }

        if (letterGrade == "A" && percent < 93)
            sign = "-";

        Console.WriteLine($"Your grade: {letterGrade}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed. You'll get them next time.");
        }
    }
}