using System;

public class GratitudeActivity : Activity
{
    private string[] _prompts =
    {
        "What is one small thing that made you smile today?",
        "Who is someone you are grateful to have in your life?",
        "What is something about yourself that you appreciate?",
        "What is a place you feel thankful for?",
        "What is an opportunity you are grateful to have?"
    };

    private Random _random = new Random();

    public GratitudeActivity()
        : base(
            "Gratitude Activity",
            "This activity will help you notice and appreciate positive things in your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Take a moment to think about each gratitude prompt.");

        int remainingSeconds = GetDuration();

        while (remainingSeconds > 0)
        {
            int promptIndex = _random.Next(_prompts.Length);
            Console.WriteLine();
            Console.WriteLine(_prompts[promptIndex]);

            int pauseSeconds = Math.Min(5, remainingSeconds);
            ShowSpinner(pauseSeconds);
            Console.WriteLine();

            remainingSeconds -= pauseSeconds;
        }

        DisplayEndingMessage();
    }
}