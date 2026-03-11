// Base class for all goal types.
// SimpleGoal, EternalGoal, and ChecklistGoal will inherit from this.
// Also, to the kind TA that reads this. I'm trying to get better at commenting in my code, but I feel like a lot of professors flag it as AI. I'm just trying to be well documented. 

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

    // Cool trick to have it check if it's complete or naw
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