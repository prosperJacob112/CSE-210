using System;

class Program
{
    static void Main(string[] args)
    {
        ///Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.Write("What is the magic number? ");
        int magic_number = int.Parse(Console.ReadLine());
        int guess_count = 0;
        
        int guess = 0;

        while (guess != magic_number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine()); 
            guess_count +=1;
            if (guess < magic_number)
            {
                Console.WriteLine("Higher");
                
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Higher");
                
            }
        else
            {
                Console.WriteLine("Your guessed it! ");
                Console.WriteLine($"You guessed {guess_count} times");
            }
        
        }


    }
}