public class Activity
{
    private string _name;
    private string _description;
    private int _duration; 

    public Activity(string name, string description) 
    {
         _name = name;
         _description = description; 

    }

    public void DisplayStartMessage() 
    { 
        Console.WriteLine($"Welcome to the {_name}."); 
        Console.WriteLine(_description); 
        Console.Write("How long, in seconds, would you like this activity to last? "); 
        _duration = int.Parse(Console.ReadLine()); 
        Console.Clear();
     }

    public void DisplayEndMessage() 
    { 
        Console.WriteLine("Great job!"); 
        Console.WriteLine($"You completed {_duration} seconds of the {_name}.");
        ShowSpinner(); }

    protected int Duration => _duration; 
    protected void ShowSpinner() 
    { 
        for (int i = 0; i < 5; i++) 
        {
            Console.Write("."); 
            Thread.Sleep(500); 
        } 
            
            Console.WriteLine(); 
    }

    protected void ShowCountdown(int seconds) 
    { 
        for (int i = seconds; i > 0; i--) 
        { 
            Console.Write(i); 
            Thread.Sleep(1000); 
            Console.Write("\b \b");
        }   Console.WriteLine(); 
    }

}