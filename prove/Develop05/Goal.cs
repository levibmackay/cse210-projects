public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public virtual int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public virtual string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"Goal:{_name},{_description},{_points}";
    }

    public bool IsComplete()
    {
        return _isComplete;
    }
}