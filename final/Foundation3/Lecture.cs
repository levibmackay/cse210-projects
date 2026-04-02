// Lecture.cs
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