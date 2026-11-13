// Personal creativity: Load the scripture text from a separate file,
// so the passage can be changed without editing the program code.


using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        Reference reference = new Reference("Genesis", 3, 1, 3);

        string text = File.ReadAllText("scripture.txt");
           

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();

            if (input != null && input.Trim().Equals( "quit", StringComparison.OrdinalIgnoreCase))
                    
            {
                break;
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}