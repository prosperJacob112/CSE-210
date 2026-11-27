using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int remainingSeconds = GetDuration();

        while (remainingSeconds > 0)
        {
            int inSeconds = Math.Min(3, remainingSeconds);
            Console.Write("Breathe in...");
            ShowCountDown(inSeconds);
            Console.WriteLine();
            remainingSeconds -= inSeconds;

            if (remainingSeconds > 0)
            {
                int outSeconds = Math.Min(3, remainingSeconds);
                Console.Write("Breathe out...");
                ShowCountDown(outSeconds);
                Console.WriteLine();
                remainingSeconds -= outSeconds;
            }
        }

        DisplayEndingMessage();
    }
}