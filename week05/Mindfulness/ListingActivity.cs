using System;

public class ListingActivity : Activity
{
    private string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int promptIndex = _random.Next(_prompts.Length);
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[promptIndex]} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int itemCount = 0;

        Console.WriteLine("Start listing:");

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items.");
        DisplayEndingMessage();
    }
}