using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine("This is the Polymorphism with Exercise Tracking program.");

        List<Activity> activities = new List<Activity>();

        Running running = new Running("03 Nov 2022", 30, 4.8);
        activities.Add(running);
        // Console.WriteLine($"{running.GetSummary()}");

        Cycling cycling = new Cycling("03 Nov 2022", 25, 15.4);
        activities.Add(cycling);
        // Console.WriteLine($"{cycling.GetSummary()}");

        Swimming swimming = new Swimming("03 Nov 2022", 6.54, 20);
        activities.Add(swimming);
        // Console.WriteLine($"{swimming.GetSummary()}");

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"{activity.GetSummary()}");
        }
    }
}