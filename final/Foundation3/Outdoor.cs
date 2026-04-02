// Outdoor.cs
public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time,
                   string street, string city, string state, string country,
                   string weather)
        : base(title, description, date, time, street, city, state, country)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        return $"Outdoor Event\n{base.StandardDetails()}\nForecast: {_weather}";
    }

    public override string ShortDescription()
    {
        return $"Outdoor: {base.ShortDescription()}";
    }
}