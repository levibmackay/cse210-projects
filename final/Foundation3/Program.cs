// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture(
            "AI Talk", "Learn about AI", "April 5", "6:00 PM",
            "123 Main St", "Rexburg", "ID", "USA",
            "Elon Musk", 100
        );

        Reception reception = new Reception(
            "Networking Night", "Meet professionals", "April 6", "7:00 PM",
            "456 Center St", "Provo", "UT", "USA",
            "rsvp@email.com"
        );

        Outdoor outdoor = new Outdoor(
            "Summer Fest", "Food and games", "June 1", "2:00 PM",
            "789 Park Ave", "Boise", "ID", "USA",
            "Sunny"
        );

        Event[] events = { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("----- STANDARD -----");
            Console.WriteLine(ev.StandardDetails());

            Console.WriteLine("\n----- FULL -----");
            Console.WriteLine(ev.FullDetails());

            Console.WriteLine("\n----- SHORT -----");
            Console.WriteLine(ev.ShortDescription());

            Console.WriteLine("\n====================\n");
        }
    }
}