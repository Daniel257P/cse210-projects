using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("04 Nov 2025", 30, 3.0));
        activities.Add(new Cycling("04 Nov 2025", 30, 6.0));
        activities.Add(new Swimming("04 Nov 2025", 30, 20));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
