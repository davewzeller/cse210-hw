public class ChecklistGoal : Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)

    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        return _amountCompleted >= _target ? _points + _bonus : _points;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetStringRepresentation() =>
        $"ChecklistGoal: {_shortName} | {_description} | {_points} | {_target} | {_bonus} | {_amountCompleted}";

    public override string GetDetailsString()
    {
        return $"[Checklist] {_shortName} — Completed {_amountCompleted}/{_target}";
    }

}
