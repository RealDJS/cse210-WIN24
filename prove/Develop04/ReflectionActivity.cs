// Develop04 source code
// Dennis Skoy
// Last edit: Mar 2024

// ReflectionActivity Class

class ReflectionActivity : Activity
{
    // Attributes
    readonly TextReader quesitons = new("reflectionQuestions.txt");
    readonly TextReader prompts = new("reflectionPrompts.txt");


    // Constructor
    public ReflectionActivity() : base("Relection", "Welcome to the Reflection Activity", "This activity will help you reflect on times in your life you demonstrated strength and resilience. This will help you recognize your capabilities and how you can use it in other aspects of your life.") { }


    // Member Methods
    public override void RunActivity() { AskAboutDay(); AskAboutMoment(); }// prompts user; questions user


    /** AskAboutDay: asks user about day */
    private void AskAboutDay()
    {
        Utility.Display("Consider the following prompt: ");
        Utility.MakeBorder("-");
        SelectText(prompts); Utility.Display(""); //provides prompt
        Utility.MakeBorder("-");
        Utility.Display("\nWhen you have something in mind, press enter to continue"); Console.ReadLine();
    }


    /** AskAboutMoment: prompts user with questions */
    private void AskAboutMoment()
    {
        Utility.Display("\nPonder on these questions as they relate to this experience");
        Utility.Display("You may begin in: "); Utility.Countdown(loadingLength);
        Console.Clear(); var startingTime = DateTime.Now;// activity start time
        while ((DateTime.Now - startingTime).TotalSeconds < activityTime)// until time runs out...
        { Utility.Display(""); SelectText(quesitons); Utility.LoadingAnimation(10); }//provides questions
    }
}