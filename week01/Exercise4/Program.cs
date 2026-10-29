
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");

        int quit = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        Console.WriteLine();

        List<int> numbers = new List<int>();
        int number = -1;
        int total = 0;
        int largest = 0;

        while (number != quit)
        {
            Console.Write("Enter your guess: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        if (numbers.Count > 0)
        {
            total = numbers.Sum();
            Console.WriteLine($"The sum is: {total}");

            double average = numbers.Average();
            Console.WriteLine($"The average is: {average}");

            largest = numbers.Max();
            Console.WriteLine($"The largest number is: {largest}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
