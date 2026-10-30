using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string promptusername()
    {
        Console.Write("Plase enter your name: ");
        string name = Console.ReadLine();
        return name;
        
    }

    static int squarenumber ()
    {
        Console.Write("Please enter your favourite number: ");
        int number = int.Parse(Console.ReadLine());
        int result = number * number;
        return result;
    }

    static void Main()
    {
      DisplayWelcome();
      Console.WriteLine();
      string PU = promptusername();
      int SN = squarenumber();
      Console.WriteLine();
      Console.WriteLine($"{PU}, the square of your number is {SN}");
      
    }

}