using System.IO;

public class GoalManager

{
    private List<Goal> _goals = new();
    private int _score = 0;
    public void AddGoal(Goal goal) => _goals.Add(goal);

    public int RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int earnedPoints = _goals[index].RecordEvent();
            _score += earnedPoints;
            return earnedPoints;
        }
        return 0;
    }




    public void DisplayPlayerInfo()
    {
    
    Console.WriteLine($"Score: {_score}");
    }
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
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
            
        }
    }


    public void LoadGoals(string filename)
    {
        try
        {
            _goals.Clear(); 
            using (StreamReader reader = new StreamReader(filename))
            {
               
                _score = int.Parse(reader.ReadLine());

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(':');
                    string type = parts[0];
                    string[] data = parts[1].Split('|');

                    switch (type)
                    {
                        case "SimpleGoal":
                            string nameS = data[0];
                            string descS = data[1];
                            int pointsS = int.Parse(data[2]);
                            bool isCompleteS = bool.Parse(data[3]);
                            var simpleGoal = new SimpleGoal(nameS, descS, pointsS);
                            if (isCompleteS) simpleGoal.RecordEvent(); 
                            _goals.Add(simpleGoal);
                            break;

                        case "EternalGoal":
                            string nameE = data[0];
                            string descE = data[1];
                            int pointsE = int.Parse(data[2]);
                            _goals.Add(new EternalGoal(nameE, descE, pointsE));
                            break;

                        case "ChecklistGoal":
                            string nameC = data[0].Trim();
                            string descC = data[1].Trim();
                            int pointsC = int.Parse(data[2].Trim());
                            int targetC = int.Parse(data[3].Trim());
                            int bonusC = int.Parse(data[4].Trim());
                            int completedC = int.Parse(data[5].Trim());
                            var checklistGoal = new ChecklistGoal(nameC, descC, pointsC, targetC, bonusC);
                            checklistGoal.SetAmountCompleted(completedC);
                            _goals.Add(checklistGoal);
                            break;

                        default:
                            Console.WriteLine($"Unrecognized goal type: {type}");
                            break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }


}