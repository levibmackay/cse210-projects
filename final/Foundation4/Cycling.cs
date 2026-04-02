/*
This file represents a cycling activity. It also inherits from the Activity class, but instead
of storing distance, it stores speed. Because of that, distance has to be calculated using the
speed and time. Pace is also calculated based on speed. This class overrides the base methods
so everything works correctly for cycling without needing to store extra data.
*/
class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}
