public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time,
                     Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return $"Reception Event\n{base.StandardDetails()}\nRSVP: {_rsvpEmail}";
    }

    public override string ShortDescription()
    {
        return $"Reception - {base.ShortDescription()}";
    }
}