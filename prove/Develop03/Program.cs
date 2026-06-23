using System;

class Program
{
    static void Main(string[] args)
    {
        // put a do while loop here to keep looping until the user inputs "quit" as a string
        bool keepGoing = true;
        // Console.WriteLine("Hello Develop03 World!");
        Reference scripref = new Reference("John", 3, 16);
        Console.WriteLine($"{scripref.GetReference()}");
        // Word word = new Word($"Test");
        // Console.WriteLine($"{word.GetWord()}");
        // word.Hide();
        // Console.WriteLine($"{word.GetWord()}");
        Scripture scripture = new Scripture(scripref,
            "For God so loved the world, " +
            "that He gave His only Begotten Son, " +
            "that whoso believeth in Him should not perish, " +
            "but have everlasting life.");
        Console.WriteLine();
        Console.Write("Press [Enter] to continue.");
        Console.ReadLine();
        scripture.Display();
        Console.WriteLine();
        Console.Write("Press [Enter] to continue.");
        Console.ReadLine();
        do
        {
            scripture.RandomWord();
            scripture.RandomWord();
            scripture.RandomWord();
            scripture.Display();
            Console.WriteLine();
            Console.WriteLine("Need a hint? Consider this: How much does God love you?");
            Console.Write("Press [Enter] to continue. Type 'quit' to end the program. ");
            string input = Console.ReadLine();
            int totalRevealed = scripture.CountRevealed();
            if (totalRevealed == 0)
            {
                keepGoing = false;
            }
            if (input.ToLower() == "quit")
            {
                keepGoing = false;
            }
        } while (keepGoing == true);
    }
}