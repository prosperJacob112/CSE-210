using System;

public class Program
{
    public static void Main()
    {
        Journal journal = new Journal();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    journal.WriteEntry();
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string loadFilename = Console.ReadLine() ?? "";

                    if (journal.LoadFromFile(loadFilename))
                    {
                        Console.WriteLine("Journal loaded.");
                    }
                    else
                    {
                        Console.WriteLine("The file could not be found or is incomplete.");
                    }
                    break;

                case "4":
                    Console.Write("What is the filename? ");
                    string saveFilename = Console.ReadLine() ?? "";

                    if (saveFilename.Trim() == "")
                    {
                        Console.WriteLine("Please enter a filename.");
                    }
                    else
                    {
                        journal.SaveToFile(saveFilename);
                        Console.WriteLine("Journal saved.");
                    }
                    break;

                case "5":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Please enter a number from 1 to 5.");
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Goodbye!");
    }
}