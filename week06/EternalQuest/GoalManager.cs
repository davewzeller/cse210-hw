public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;
    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordEvent(int index)
    {
        if (index > 0 && index < _goals.Count)
            _score += _goals[index].RecordEvent();
    }

    public void DisplayPlayerInfo() => Console.WriteLine($"Score: {_score}");

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._shortName}");

        }

    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetaillsString());
        }
    }

    // how to write to a file?
}