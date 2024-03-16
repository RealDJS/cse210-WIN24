// Develop05
// Dennis Skoy
// Mar 2024

// EternalQuestMenu

class EternalQuestMenu
{
    //Attributes
    private Goals goals;

    // Methods
    /** UseMenu: uses the menu */
    public static object UseMenu(Goals goals)
    {
        while (true)
        {
            Console.WriteLine();
            Console.Write(
            $"""
			You have {goals.GetScore()} points.
			
			1. Make a goal
			2. List goals
			3. Save goals
			4. Load goals
			5. Record an event
			6. Quit
			""");
            Console.WriteLine("\nEnter an option: ");
            var option = Console.ReadLine();
            ChooseOption(goals, option);
        }
    }


    /** ChooseOption: chooses an option */
    private static void ChooseOption(Goals goals, string option)
    {
        Action action = option switch
        {
            "1" => () => MakeGoal(goals),
            "2" => () => ListGoals(goals),
            "3" => () => SaveGoals(goals),
            "4" => () => LoadGoals(goals),
            "5" => () => RecordEvent(goals),
            "6" => () => Quit(),
            _ => () => DefaultOption()
        }; action();
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

            Console.WriteLine("Enter the type of goal: ");
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
    {
        Serializer serial = new Serializer("goals.json");
        serial.Serialize(goals);
    }


    /** LoadGoals: loads goals from files */
    private static void LoadGoals(Goals goals)
    { goals.LoadGoals("goals.json"); }


    /** RecordEvent: records a goal event */
    private static void RecordEvent(Goals goals)
    {
        Console.WriteLine("What goal did you accomplish?");
        int userInteger = int.Parse(Console.ReadLine());
    }


    /** DefaultOption: default option */
    private static void DefaultOption() { Console.WriteLine("Invalid input."); }


    /** Quit: quits the program */
    private static void Quit() { Console.Clear(); Environment.Exit(0); }
}