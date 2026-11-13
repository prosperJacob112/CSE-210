using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        Reference reference = new Reference("Genesis", 3, 1, 3);

        string text =
            "Now the serpent was more subtil than any beast of the field " +
            "which the LORD God had made. And he said unto the woman, " +
            "Yea, hath God said, Ye shall not eat of every tree of the garden? " +
            "And the woman said unto the serpent, We may eat of the fruit " +
            "of the trees of the garden: But of the fruit of the tree which " +
            "is in the midst of the garden, God hath said, Ye shall not eat " +
            "of it, neither shall ye touch it, lest ye die.";

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