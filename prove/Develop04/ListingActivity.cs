// Develop04 source code
// Dennis Skoy; ChatGPT4 assistance
// Last edit: Mar 2024

// ListingActivity Class

class ListingActivity : Activity
{
    // Attributes
    readonly TextReader listingQuestions = new("listingPrompts.txt");

    public ListingActivity() : base("Listing",
    "Welcome to the Listing Activity",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }


    // Member Methods
    public override void RunActivity() { AskQuestion(); SynchronizeList(); }//asks user question; user provides answers within a timeframe


    /**AskQuestion*/
    private void AskQuestion()
    {
        Utility.Display("List as many responses as you can to the following response: ");
        Utility.MakeBorder("-"); SelectText(listingQuestions); Utility.Display(""); Utility.MakeBorder("-");
        Utility.Countdown(loadingLength); Utility.Display("");
    }


    /** SynchronizeList: // syncs the methods together */
    private void SynchronizeList() { ListInputs().GetAwaiter().GetResult(); }


    /** ListInputs: Lists user's inputs within the activityTime */// referred to ChatGPT for method. Comments are my own
    private async Task ListInputs()
    {
        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(activityTime));// creates timespan for activity
        var inputs = await CollectInputs(cts.Token);// list from user within timespan
        cts.Dispose(); Utility.Display($"You listed {inputs.Count} items!!!"); // shuts down the token; shows results
    }


    /** CollectInputs Method: allows inputs to be collected while the timer is running */// referred to ChatGPT for method. Comments are my own
    private async Task<List<string>> CollectInputs(CancellationToken cancellationToken)
    {
        var inputs = new List<string>();//empty list for user inputs
        while (!cancellationToken.IsCancellationRequested)// while NOT requested to stop:
        {
            if (Console.KeyAvailable)// IF User pressed a key:
                                     // reads input; IF user enters anything: adds input to List
            { var input = Console.ReadLine(); if (!string.IsNullOrWhiteSpace(input)) { inputs.Add(input); } }
            await Task.Delay(100);// waits 100 miliseconds before moving on
        }
        return inputs;//returns list
    }
}