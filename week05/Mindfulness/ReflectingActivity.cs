public class ReflectingActivity: Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
        : base("Reflecting Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

private string GetRandomPrompt()
{
    Random rand = new Random();
    int index = rand.Next(_prompts.Count);
    return _prompts[index];
}
private string GetRandomQuestion()
{
    Random rand = new Random();
    int index = rand.Next(_questions.Count);
    return _questions[index];
}

public void Run()
{
    DisplayStartMessage();

    string prompt = GetRandomPrompt();
    Console.WriteLine("Consider the following prompt:");
    Console.WriteLine($"--- {prompt} ---");
    Console.WriteLine("You may begin reflecting in:");
    ShowCountdown(5);

    Console.Clear();
    Console.WriteLine($"--- {prompt} ---");
    Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

    DateTime endTime = DateTime.Now.AddSeconds(Duration);

    while (DateTime.Now < endTime)
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"> {question}");
        ShowCountdown(5); 
        Console.WriteLine();
    }

    DisplayEndMessage();
}
}