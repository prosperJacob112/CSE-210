using System;

class Program
{
    static void Main(string[] args)
    {
        string Grade1 = "A";
        string Grade12 = "A-";
        string Grade2 = "B+";
        string Grade22 = "B-";
        string Grade3 = "C+";
        string Grade32 = "C-";
        string Grade4 = "D+";
        string Grade42 = "D-";
        string Grade5 = "F";
        //Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name} Welcome to the Grade calculator.");
        Console.WriteLine();
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        
        if (grade >= 95 && grade < 101)
        {
            Console.WriteLine($"Your grade is an {Grade1}.");
            Console.WriteLine($"Congratulations {name}, you passed, you are promoted to the next grade.");
        }
        else if (grade >= 90 && grade < 95)
        {
            Console.WriteLine($"Your grade is an {Grade12}.");
            Console.WriteLine($"Congratulations {name}, you passed, you are promoted to the next grade.");
        }
        else if (grade >= 85 && grade < 90)
        {
            Console.WriteLine($"Your grade is a {Grade2}.");
            Console.WriteLine($"Congratulations {name}, you passed, you are promoted to the next grade.");
        }
        else if (grade >= 80 && grade < 85)
        {
            Console.WriteLine($"Your grade is {Grade22}");
             Console.WriteLine($"Congratulations {name}, you passed, you are promoted to the next grade.");
        }
        else if (grade >= 75 && grade < 80)
        {
            Console.WriteLine($"Your grade is a {Grade3}.");
            Console.WriteLine($"Congratulations {name}, you passed, you are promoted to the next grade.");
        }
        else if (grade >= 70 && grade < 75)
        {
           Console.WriteLine($"Your grade is {Grade32}");
           Console.WriteLine($"Congratulations {name}, you passed, you are promoted to the next grade.");
        }

        else if (grade >= 65 && grade < 70)
        {
            Console.WriteLine($"Your grade is a {Grade4}.");
            Console.WriteLine($"Hey {name}, you barely passed. There is room for improvement.");
        }
        else if (grade >= 60 && grade <65)
        {
            Console.WriteLine($"Your Grade is {Grade42}");
            Console.WriteLine($"Hey {name}, you barely passed. There is room for improvement.");
        }
        else if (grade < 60)
        {
            Console.WriteLine($"Your grade is an {Grade5}.");
            Console.WriteLine($"Sorry {name}, you failed. You are required to repeat this grade.");
        }
        else
        {
            Console.WriteLine($"Sorry! {name}, you entered an invalid grade percentage.    \n Please enter a valid grade percentage between 0 and 100.");
            Console.WriteLine();
        }
    }   
       
}