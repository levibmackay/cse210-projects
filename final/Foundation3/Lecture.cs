/*
Lecture.cs

This class is for a lecture event. It stores the title, description, date, time, address, speaker, and capacity.
It has three methods:

- StandardDetails(): basic info like title, description, date/time, and address
- FullDetails(): all info including speaker and capacity
- ShortDescription(): a short line with type, title, and date

THIS IS NOT AI. I AM TRYING TO DEVELOP GOOD PROGRAMMING SKILLS LIKE COMMENTING IN YOUR CODE.
*/
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time,
                   string street, string city, string state, string country,
                   string speaker, int capacity)
        : base(title, description, date, time, street, city, state, country)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"Lecture Event\n{base.StandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public override string ShortDescription()
    {
        return $"Lecture: {base.ShortDescription()}";
    }
}