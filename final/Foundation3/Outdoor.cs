/*
This class is for an outdoor event. It stores weather info.
*/
public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time,
                   Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        return $"Outdoor Event\n{base.StandardDetails()}\nForecast: {_weather}";
    }

    public override string ShortDescription()
    {
        return $"Outdoor - {base.ShortDescription()}";
    }
}