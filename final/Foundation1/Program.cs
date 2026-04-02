/* I'm really trying to get better at leaving comments. I'm trying to fully document what I did.
At the career fair, I had an employer who mentioned that commenting and organization is something that they really look for.
I DID NOT USE AI FOR THIS CODE. I'm just trying to get better at what we are taught to do.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        /* First, I’m creating four video objects. For each one, I set the title, author, and length.
        Then, I add a few comments to each video. I’m using a constructor for Comment so I don’t
        have to call separate SetName or SetText methods. This keeps things simple and readable. */

        Video video1 = new Video();
        video1.SetVideoDetails("Gym Motivation", "FitnessPro", 600);
        video1.AddComment(new Comment("Levi", "This got me hyped"));
        video1.AddComment(new Comment("Jake", "Great video bro"));
        video1.AddComment(new Comment("Sam", "Needed this today"));

        Video video2 = new Video();
        video2.SetVideoDetails("Car Mods", "AutoGuy", 450);
        video2.AddComment(new Comment("Chris", "Clean build"));
        video2.AddComment(new Comment("Tyler", "What exhaust is that?"));
        video2.AddComment(new Comment("Alex", "Sounds insane"));

        Video video3 = new Video();
        video3.SetVideoDetails("How to Cook Pasta", "Chef Mike", 300);
        video3.AddComment(new Comment("Emma", "Super easy recipe"));
        video3.AddComment(new Comment("Noah", "Turned out great"));
        video3.AddComment(new Comment("Olivia", "Thanks for this"));

        Video video4 = new Video();
        video4.SetVideoDetails("Snowboarding Tricks", "SnowPro", 520);
        video4.AddComment(new Comment("Ethan", "That jump was crazy"));
        video4.AddComment(new Comment("Mason", "Trying this next time"));
        video4.AddComment(new Comment("Logan", "Respect bro"));

        /* Next, I put all the videos into a list so I can loop through them easily.
        Then, for each video, I print out the title, author, length, and how many comments it has.
        Inside that loop, I also loop through each comment and print who said it and what they said.
        Adding a blank line after each video keeps the output organized. */
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}