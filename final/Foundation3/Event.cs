// Event.cs
public class Event
{
    // Private variables
    private string _title;
    private string _description;
    private string _date;
    private string _time;

    // Address info included in base class for simplicity
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor
    public Event(string title, string description, string date, string time,
                 string street, string city, string state, string country)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;

        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Standard details
    public virtual string StandardDetails()
    {
        return $"{_title}\n{_description}\n{_date} at {_time}\n{_street}, {_city}, {_state}, {_country}";
    }

    // Full details - will be overridden
    public virtual string FullDetails()
    {
        return StandardDetails();
    }

    // Short description
    public virtual string ShortDescription()
    {
        return $"{_title} - {_date}";
    }
}