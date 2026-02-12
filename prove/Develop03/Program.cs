using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Scripture> list = new List<Scripture>();

        list.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
        ));

        list.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"
        ));

        list.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me"
        ));

        Random rand = new Random();
        Scripture chosen = list[rand.Next(list.Count)];

        bool done = false;

        while (!done)
        {
            Console.Clear();
            Console.WriteLine(chosen.GetDisplayText());

            if (chosen.AllHidden())
            {
                done = true;
            }
            else
            {
                Console.Write("\nPress Enter to continue or type 'quit':");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    done = true;
                }
                else
                {
                    chosen.HideRandomWords(3);
                }
            }
        }
    }
}
