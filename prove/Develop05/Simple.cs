// SimpleGoal is a goal that can only be completed once.
// After it is marked complete, the user can't earn points from it again.
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }

        return 0;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_description},{_points}";
    }
}