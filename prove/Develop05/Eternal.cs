// EternalGoal represents goals that never really finish,
// like reading scriptures or praying daily.
// Stuff you have to do to get eternal blessings
public class EternalGoal : Goal
{
    // Don't put a _isComplete bc the goal is eternal
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_name} ({_description}) (∞)";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_description},{_points}";
    }
}