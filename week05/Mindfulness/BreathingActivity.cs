public class BreathingActivity: Activity
{
    public BreathingActivity() 
    : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.")
    {}
    public void Run() 
    { 
        DisplayStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(Duration); 
        while (DateTime.Now < endTime) 
        { 
            Console.Write("Breathe in... "); 
            ShowCountdown(4); 
            Console.Write("Breathe out... ");
            ShowCountdown(6); 
            Console.WriteLine(); 
        } 
            
            DisplayEndMessage();
    }
    protected void ShowCountdown(int seconds) 
    { 
        for (int i = seconds; i > 0; i--) 
        { 
            Console.Write(i); 
            Thread.Sleep(1000); 
            Console.Write("\b \b");
        } 
    
            Console.WriteLine();
    }
}