public class PromptGenerator
{
    public List<string> _prompt = new List<string>()
    {
        "What was the best part of your day?",
        "Describe a memorable moment from your childhood.",
        "What are you grateful for today?",
        "Write about a challenge you overcame recently.",
        "What is a goal you have for the next month?"
    };

    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompt.Count);
        return _prompt[index];
    }
}
