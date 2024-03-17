// Develop05
// Dennis Skoy
// Mar 2024

// EternalQuestMenu

class EternalQuestMenu
{
    // Methods
    /** UseMenu: uses the menu */
    public static object UseMenu(Goals goals)
    {
        Console.Clear();
        while (true)
        {

            goals.CalcScore();
            Console.WriteLine();
            Console.Write(
            $"""
			You have {goals.Score} points.

			1. Make a goal
			2. List goals
			3. Save goals
			4. Load goals
			5. Record an event
			6. Quit
			""");
            Console.Write("\nEnter an option: ");
            string option = Console.ReadLine();
            Console.WriteLine();
            ChooseOption(ref goals, option);
        }
    }


    /** ChooseOption: chooses an option */
    private static void ChooseOption(ref Goals goals, string option)
    {
        switch (option)
        {
            case "1": MakeGoal(goals); break;
            case "2": ListGoals(goals); break;
            case "3": SaveGoals(goals); break;
            case "4": goals = LoadGoals(); break;
            case "5": RecordEvent(goals); break;
            case "6": Quit(); break;
            default: DefaultOption(); break;
        }
    }


    /** MakeGoal: makes a new goal */
    private static void MakeGoal(Goals goals)
    {
        Goal goal;//goal to be created
        Console.WriteLine("Enter the name of the goal: ");//gets name
        string name = Console.ReadLine();

        Console.WriteLine("Enter a short description of the goal: ");//gets description
        string description = Console.ReadLine();

        Console.WriteLine("Enter the points for the goal: ");//gets points
        int points = int.Parse(Console.ReadLine());

        while (true)//loops until valid input
        {
            Console.WriteLine();
            Console.Write(
            """
			1. Simple
			2. Eternal
			3. Checklist
			""");
            Console.WriteLine("\nEnter the type of goal: ");
            string type = Console.ReadLine();

            if (type == "1")//creates simple
            { goal = new Simple(name, description, points); break; }

            else if (type == "2")//creates eternal
            { goal = new Eternal(name, description, points); break; }

            else if (type == "3")//creates checklist
            {
                Console.WriteLine("Enter the number of items needed: ");//gets number of items needed
                int howManyNeeded = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the bonus points for completion: ");//gets bonus points
                int bonusPoints = int.Parse(Console.ReadLine());

                goal = new Checklist(name, description, points, howManyNeeded, bonusPoints);
                break;
            }
            else { Console.WriteLine("Invalid input."); }
        }
        goals.AddGoal(goal);
    }


    /** ListGoals: lists current goals */
    private static void ListGoals(Goals goals) { goals.ListGoals(); }


    /** SaveGoals: saves goals to files */
    private static void SaveGoals(Goals goals)
    { Serializer serial = new Serializer(); serial.SerializeTypes(goals); }


    /** LoadGoals: loads goals from files */
    private static Goals LoadGoals()
    {
        Serializer serial = new Serializer();

        var simpleGoals = serial.DeserializeSimple();//gets Simple Goals from files
        var eternalGoals = serial.DeserializeEternal();//gets Eternal Goals from files
        var checklistGoals = serial.DeserializeChecklist();//gets Checklist Goals from files

        Goals loadingGoals = new Goals();//creates new Goals object

        foreach (Simple goal in simpleGoals) { loadingGoals.AddGoal(goal); }
        foreach (Eternal goal in eternalGoals) { loadingGoals.AddGoal(goal); }
        foreach (Checklist goal in checklistGoals) { loadingGoals.AddGoal(goal); }

        return loadingGoals;//returns Goals object
    }


    /** RecordEvent: records a goal event */
    private static void RecordEvent(Goals goals)
    {
        for (int i = 0; i < goals.GoalsList.Count; i++)//lists goals
        { Console.WriteLine($"{i + 1}. " + goals.GoalsList[i].ToString()); }//
        Console.WriteLine("What goal did you accomplish?");
        int userInteger = int.Parse(Console.ReadLine());//gets goal number
        Goal goal = goals.GoalsList[userInteger - 1];//gets goal
        goal.CompleteGoal();//records goal
    }


    /** DefaultOption: default option */
    private static void DefaultOption() { Console.WriteLine("Invalid input."); }


    /** Quit: quits the program */
    private static void Quit() { Console.Clear(); Environment.Exit(0); }
}