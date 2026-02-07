public class ListingActivity: Activity
{
    private List<string> _prompts = new List<string> 
    { 
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?",
         "When have you felt the Holy Ghost this month?", 
         "Who are some of your personal heroes?"
    }; 
    
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing items.") { }    

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    public void Run()
    {
        DisplayStartMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin in:");
        ShowCountdown(5); 

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        Console.WriteLine($"You listed {responses.Count} items.");
        DisplayEndMessage();
    }

}