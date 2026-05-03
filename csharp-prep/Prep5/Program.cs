using System;

class Program
{
    static void Main(string[] args)
    {
        ProgramStartMessage();

        string userName = AskName();

        int favoriteNumber = AskFavNumber();

        int squaredNumber = SquareGivenNumber(favoriteNumber);

        int birthYear;

        AskBirthYear(out birthYear);

        FinalResult(userName, squaredNumber, birthYear);
    }

    static void ProgramStartMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string AskName()
    {
        Console.Write("Please enter your name: ");

        string name = Console.ReadLine();

        return name;
    }

    static int AskFavNumber()
    {
        Console.Write("Please enter your favorite number: ");

        int number = int.Parse(Console.ReadLine());

        return number;
    }
    
    static void AskBirthYear(out int birthYear)
    {
        Console.Write($"Please enter the year you were born: ");

        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareGivenNumber(int number)
    {
        int square = number * number;
        
        return square;
    }

    static void FinalResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} years old this year.");
    }
}