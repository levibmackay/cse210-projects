/*
This file represents a swimming activity. It stores the number of laps instead of distance
or speed. The distance is calculated using the number of laps and the length of the pool,
which is 50 meters per lap. Then it converts that into miles. Speed and pace are calculated
based on that distance and the time. This class overrides the methods from the base class
so the calculations match how swimming works.
*/
class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50 / 1000.0) * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}