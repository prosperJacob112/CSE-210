using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("A random number has been generated from 1 to 100, for you to guess");
        Console.WriteLine();
        int guess_count = 0;
        
        int guess = 0;
        Random numberpicker = new Random();
        int magic_number =  numberpicker.Next(1, 101);
        while (guess != magic_number)
        {
            Console.Write("What is your guess: ");
            guess = int.Parse(Console.ReadLine());
            guess_count +=1;
            if (guess < magic_number)
            {
                Console.WriteLine("Higher");
                
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
                
            }
        else
            {
                Console.WriteLine();
                Console.WriteLine("Your guessed it! ");
                Console.WriteLine($"You guessed {guess_count} times");
            }
        
        }


    }
}