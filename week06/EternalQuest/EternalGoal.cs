public class EternalGoal : Goal
{
    public EternalGoal(String name, string description, int points)
        : base(name, description, points)
    {

    }

    public override int RecordEvent() => _points;

    public override bool IsComplete() => false;

    public override string GetDetaillsString() =>
     "[Eternal] " + _shortName;

    public override string GetStringRepresentation() =>
        $"EternalGoal:{_shortName}|{_description}|{_points}";

}



