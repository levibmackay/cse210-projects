/*
This file represents a running activity. It inherits from the Activity class and adds distance
as its own specific piece of data. Since running already gives distance directly, the calculations
for speed and pace are based on that value and the time. This class overrides the methods from
the base class so that it returns the correct values for running instead of the default ones.
*/
class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }
}