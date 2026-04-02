/*
This file is the base class for all activities in the program. It holds the shared information
like the date and how many minutes the activity lasted. It also defines methods for getting
distance, speed, and pace, but those are just placeholders here and get overridden in the
other classes. The GetSummary method is also in this class, which builds a clean string using
the other methods. The main purpose of this class is to avoid repeating code and to let the
other activity classes inherit from it and customize their own calculations.
*/

class Activity
{
    private string _date;
    private int _minutes;
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public string GetDate()
    {
        return _date;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min) - " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace {GetPace():0.0} min per mile";
    }
}
