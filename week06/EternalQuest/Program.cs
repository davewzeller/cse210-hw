using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("-----The Eternal Quest Program -----");
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List The Goals Details");
            Console.WriteLine("3. Record it");
            Console.WriteLine("4. Save the Goal");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Pick and Option: ");
            manager.DisplayPlayerInfo();
            string input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    CreateGoal(manager);
                    break;

                case "2":
                    manager.ListGoalDetails();
                    Pause();
                    break;

                case "3":
                    RecordGoal(manager);
                    Pause();
                    break;

                case "4":
                    Console.Write("Enter filename to save to: ");
                    string saveName = Console.ReadLine();
                    manager.SaveGoals(saveName);
                    Console.WriteLine("Goals Saved. ");
                    Pause();
                    break;

                case "5":
                    Console.Write("Enter filename to load: ");
                    string loadName = Console.ReadLine();
                    manager.LoadGoals(loadName);
                    Console.WriteLine("Goals Loaded. ");
                    Pause();
                    break;

                case "6":
                    running = false;
                    break;


                default:
                    Console.WriteLine("Something went wrong try again. ");
                    Pause();
                    break;



            }
        }

    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("\nChoose Goal Type: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, desc, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Target repetitions: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus repetitions: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default:
                Console.WriteLine("Wrong choice. ");
                break;


        }
    }
    static void RecordGoal(GoalManager manager)
    {
        Console.WriteLine("\nWhich goal did you accomplish?");
        manager.ListGoalNames();
        Console.Write("Goal #: ");
        int index = int.Parse(Console.ReadLine()) - 1;
       
        Console.WriteLine("Event recorded!");
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue....");
        Console.ReadLine();
    }
}
