public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        _currentCount++;

        if (_currentCount >= _targetCount)
        {
            _isComplete = true;
            return _points + _bonus;
        }

        return _points;
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";

        return $"{status} {_name} ({_description} -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_targetCount},{_bonus},{_currentCount}";
    }
}