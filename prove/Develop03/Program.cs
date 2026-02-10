using System;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("John", 3, 16);

        Scripture scripture = new Scripture(
            reference,
            "For God so loved the world that he gave his only begotten Son"
        );

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.AllHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit':");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
