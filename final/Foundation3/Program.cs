/*
This is the main file. It makes one event of each type (lecture, reception, outdoor), fills in their info,
and then prints out the standard, full, and short details for each one so we can see the messages.

THIS IS NOT AI. I AM TRYING TO DEVELOP GOOD PROGRAMMING SKILLS LIKE COMMENTING IN YOUR CODE. 
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address addr2 = new Address("456 Center St", "Provo", "UT", "USA");
        Address addr3 = new Address("789 Park Ave", "Boise", "ID", "USA");

        Lecture lecture = new Lecture(
            "AI Talk", "Learn about AI", "April 5", "6:00 PM",
            addr1, "Elon Musk", 100
        );

        Reception reception = new Reception(
            "Networking Night", "Meet professionals", "April 6", "7:00 PM",
            addr2, "rsvp@email.com"
        );

        Outdoor outdoor = new Outdoor(
            "Summer Fest", "Food and games", "June 1", "2:00 PM",
            addr3, "Sunny"
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