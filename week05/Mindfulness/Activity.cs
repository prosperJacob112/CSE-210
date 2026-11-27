using System.Threading;
public class Activity
{
    private string _activityName = "";
    private string _description = "";
    private int _duration ;

   public Activity(string activityName, string description)
   {
     _activityName = activityName;
     _description = description;
     
   }
   public void DisplayStartingMessage()
   {
     Console.WriteLine($"Welcome to the {_activityName}.");
     Console.WriteLine();
     Console.WriteLine(_description);
     Console.WriteLine();
     Console.Write("How long, in seconds, would you like for your session? ");

     _duration = int.Parse(Console.ReadLine());
     Console.WriteLine();
     Console.WriteLine("Get ready...");
     ShowSpinner(3);
   }
    public void ShowSpinner(int seconds)
    {
      string[] symbols = { "|", "/", "-", "\\" };
      DateTime endTime = DateTime.Now.AddSeconds(seconds);
      int index = 0;

      while (DateTime.Now < endTime)
      {
        Console.Write(symbols[index]);
        Thread.Sleep(250);
        Console.Write("\b");

        index = (index + 1) % symbols.Length;
      }

      Console.Write(" \b");
    }
    public void DisplayEndingMessage()
    {
      Console.WriteLine();
      Console.WriteLine("Well done!!");
      ShowSpinner(3);

      Console.WriteLine();
      Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");

      ShowSpinner(3);
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected int GetDuration()
    {
        return _duration;
    }
}

