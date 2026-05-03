using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int numberKnown = randomGenerator.Next(1, 101);

        int userGuess = -1;

        while (userGuess != numberKnown)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (numberKnown > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (numberKnown < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}