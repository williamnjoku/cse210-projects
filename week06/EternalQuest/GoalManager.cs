public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public GoalManager()
    {

    }
    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is {_score}");
    }
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to show.");
            return;
        }

        Console.WriteLine("Your goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("Choose the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points for completing this goal: ");
        int points = int.Parse(Console.ReadLine());

        int target = 0, bonus = 0;
        if (choice == "3")
        {
            Console.Write("Enter the number of times required to complete: ");
            target = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points for completion: ");
            bonus = int.Parse(Console.ReadLine());
        }
        Goal newGoal;

        if (choice == "1")
        {
            newGoal = new SimpleGoals(name, description, points);
        }
        else if (choice == "2")
        {
            newGoal = new EternalGoals(name, description, points);
        }
        else if (choice == "3")
        {
            newGoal = new CheckListGoals(name, description, points, target, bonus);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal added successfully!");

    }
    public void RecordEvent()
    {
        Console.WriteLine("Here are your goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Enter the number of the goal you completed: ");
        string input = Console.ReadLine();
        int index;

        if (int.TryParse(input, out index) && index > 0 && index <= _goals.Count)
        {
            Goal selectedGoal = _goals[index - 1]; 
            selectedGoal.RecordEvent();

            int pointsEarned = 0;
            if (selectedGoal is CheckListGoals checklistGoal)
            {
                pointsEarned = checklistGoal.CalculatePointsEarned();
            }
            else
            {
                pointsEarned = selectedGoal.GetPoints();
            }

            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points! Total Score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter a valid number.");
        }
    }
    public void ShowMenu()
    {
        Console.WriteLine("1. Create a new Goal");
        Console.WriteLine("2. Record a completed goal");
        Console.WriteLine("3. Show all goals");
        Console.WriteLine("4. Show total score");
        Console.WriteLine("5. Save goals to a file");
        Console.WriteLine("6. Load goals from a file");
        Console.WriteLine("7. Show overall goal progress"); 
        Console.WriteLine("8. Exit");
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            ShowMenu();
            string choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") RecordEvent();
            else if (choice == "3") DisplayGoals();
            else if (choice == "4") DisplayScore();
            else if (choice == "5") SaveGoals();
            else if (choice == "6") LoadGoals();
            else if (choice == "7") 
            {
                DisplayProgress();  
            }
            else if (choice == "8")
            {
                running = false;
            } 
            else 
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter the filename to save your goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }

            writer.WriteLine($"Score,{_score}");
        }

        Console.WriteLine("Goals and score have been saved!");
    }
    public void LoadGoals()
    {
        Console.Write("Enter the filename to load your goals: ");
        string filename = Console.ReadLine();


        if (File.Exists(filename))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts[0] == "SimpleGoal")
                {
                    _goals.Add(new SimpleGoals(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (parts[0] == "EternalGoal")
                {
                    _goals.Add(new EternalGoals(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    var goal = new CheckListGoals(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    goal.SetAmountCompleted(int.Parse(parts[6]));
                    _goals.Add(goal);
                }
                else if (parts[0] == "Score")
                {
                    _score = int.Parse(parts[1]);
                }
            }

            Console.WriteLine("Goals and score have been loaded!");
        }
        else
        {
            Console.WriteLine("No file found.");
        }
    }
    public void ExitProgram()
    {
        SaveGoals();  
    }
    public void DisplayProgress()
    {
        int totalGoals = _goals.Count;
        int completedGoals = _goals.Count(goal => goal.IsComplete());

        Console.WriteLine($"You have {completedGoals} out of {totalGoals} goals completed.");
    }


}