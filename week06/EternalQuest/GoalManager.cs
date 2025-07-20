using System.IO;

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
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");


        }

    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());

        }
    }


    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score); // First line is the score
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation()); // Custom format per goal type
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');
            string type = parts[0];
            string[] data = parts[1].Split('|');

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]))
                    {

                    });
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    break;

                case "ChecklistGoal":
                    var checklist = new ChecklistGoal(data[0], data[1], int.Parse(data[2]),
                                                      int.Parse(data[3]), int.Parse(data[4]));
                    checklist.SetAmountCompleted(int.Parse(data[5]));
                    _goals.Add(checklist);
                    break;

            }
        }
    }

}