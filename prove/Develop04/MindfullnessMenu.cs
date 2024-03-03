// Develop04 Source code
// Dennis Skoy
// Last edit: Mar 2024

// MindfulnessMenu Class

class MindfulnessMenu
{
    // Member Methods

    public static object UseMenu() { while (true) { DisplayMenu(); GetOption(); } }// loops indfinitly; presents options; gets user input

    private static void DisplayMenu()
    {
        Console.Clear(); Utility.MakeBorder("=");
        Console.WriteLine("Activity Options:"); Utility.MakeBorder("=");
        Console.Write("""
				1. Start Breathing Activity
				2. Start Reflecting Activity
				3. Start Lisitng Activity
				4. Quit
			""");
    }


    /** Gets user's option*/
    private static void GetOption()
    {
        Console.Write("\nSelect a choice from the menu: "); var option = Console.ReadLine();// reads input
        ChooseActivity(option);//executes action based on user choice
    }


    private static void ChooseActivity(string option)
    {
        Action action = option switch
        {
            "1" => () => new BreathingActivity().PresentActivity(),
            "2" => () => new ReflectionActivity().PresentActivity(),
            "3" => () => new ListingActivity().PresentActivity(),
            "4" => () => Quit(),//leaves program
            _ => () => Utility.DefaultOption()//stops invalid inputs
        }; action();
    }

    private static void Quit() { Console.Clear(); Environment.Exit(0); }// leaves program
}