/*
This class is for any kind of event. It stores the basic info like title, description, date, time, and the address. 
It has methods to show the standard details, full details, and a short description. 
This is where the general info for all events is kept so the other event types can use it. 

THIS IS NOT AI. I AM TRYING TO DEVELOP GOOD PROGRAMMING SKILLS LIKE COMMENTING IN YOUR CODE.
*/
public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string StandardDetails()
    {
        return $"{_title}\n{_description}\n{_date} at {_time}\n{_address.GetAddress()}";
    }

    public virtual string FullDetails()
    {
        return StandardDetails();
    }

    public virtual string ShortDescription()
    {
        return $"{_title} - {_date}";
    }
}
