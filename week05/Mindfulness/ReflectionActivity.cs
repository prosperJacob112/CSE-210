using System;

public class ReflectionActivity : Activity
{
    private string[] _prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _random = new Random();

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }
    public void Run()
    {
        DisplayStartingMessage();

        int promptIndex = _random.Next(_prompts.Length);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_prompts[promptIndex]} ---");
        Console.WriteLine("Reflect on this experience as you consider the questions below.");

        int remainingSeconds = GetDuration();

        while (remainingSeconds > 0)
        {
            int questionIndex = _random.Next(_questions.Length);
            Console.WriteLine($"> {_questions[questionIndex]}");

            int pauseSeconds = Math.Min(5, remainingSeconds);
            ShowSpinner(pauseSeconds);
            Console.WriteLine();

            remainingSeconds -= pauseSeconds;
        }

        DisplayEndingMessage();
    }

}