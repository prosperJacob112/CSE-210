using System;
// Personal creativity: I added a fourth activity called Gratitude Activity suggested by my instructor.
// It uses gratitude prompts to help users notice and appreciate positive things in their lives.
public class Program
{
    public static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;
        int gratitudeCount = 0;
        bool running = true;

        // Creativity: tracks completed activities during this program session.
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start gratitude activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
                reflectionCount++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                GratitudeActivity activity = new GratitudeActivity();
                activity.Run();
                gratitudeCount++;
            }
            else if (choice == "5")
            {
                Console.WriteLine();
                Console.WriteLine("Activities completed this session:");
                Console.WriteLine($"Breathing: {breathingCount}");
                Console.WriteLine($"Reflection: {reflectionCount}");
                Console.WriteLine($"Listing: {listingCount}");
                Console.WriteLine($"Gratitude: {gratitudeCount}");
                Console.WriteLine("Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Please enter 1, 2, 3, or 4.");
            }
        }
    }
}