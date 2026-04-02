// Reception.cs
public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time,
                     string street, string city, string state, string country,
                     string rsvpEmail)
        : base(title, description, date, time, street, city, state, country)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return $"Reception Event\n{base.StandardDetails()}\nRSVP: {_rsvpEmail}";
    }

    public override string ShortDescription()
    {
        return $"Reception: {base.ShortDescription()}";
    }
}