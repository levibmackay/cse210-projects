/*
Outdoor.cs

This class is for an outdoor event. It stores the title, description, date, time, address, and weather info.
It has three methods:

- StandardDetails(): basic info like title, description, date/time, and address
- FullDetails(): all info including weather
- ShortDescription(): a short line with type, title, and date

THIS IS NOT AI. I AM TRYING TO DEVELOP GOOD PROGRAMMING SKILLS LIKE COMMENTING IN YOUR CODE.
*/
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