using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal(); // initializes new Journal (this should be done before the menu)
        File file = new File(); // initializes new File (this should also be done before the menu)
        string input = "";
        do
        {


            string menuText = @"
Welcome to the Journal program!
Please choose one of the following options by number (#):
(1). Write a new entry!
(2). Read your journal!
(3). Save your journal!
(4). Load an old journal!
(5). Perish!
";
            Console.WriteLine(menuText);
            input = Console.ReadLine();

            if (input == "1")
            {
                journal.AddEntry(journal.PullPrompt()); // one of the menu items
            }
            else if (input == "2")
            {
                journal.DisplayEntries(); // a different menu item
            }
            else if (input == "3")
            {
                file.Save(journal); // for the Save menu item
            }
            else if (input == "4")
            {
                journal = file.Load();// for the Load menu item
            }
            else if (input == "5")
            {
                Console.Write("Goodbye.");
            }
            else Console.Write("Pick an integer between 1 and 5, including 1 or 5.");
        } while (input != "5");
    }
}