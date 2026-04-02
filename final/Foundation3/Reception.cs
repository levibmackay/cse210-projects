/*
This class is for a reception event. It stores the title, description, date, time, address, and RSVP email.
It has three methods:

- StandardDetails(): basic info like title, description, date/time, and address
- FullDetails(): all info including the RSVP email
- ShortDescription(): a short line with type, title, and date

THIS IS NOT AI. I AM TRYING TO DEVELOP GOOD PROGRAMMING SKILLS LIKE COMMENTING IN YOUR CODE.
*/
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