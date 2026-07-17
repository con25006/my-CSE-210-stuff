using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine("This is the Inheritance with Event Planning program.");
        Console.WriteLine("\n");Console.WriteLine("");

        // Event 1 - Lecture
        Address address1 = new Address("123 Sample Street", "New Sample City", "Wyoming 2", "USA");
        Lectures lectures = new Lectures("How to Give a Lecture", "A lecture about the best ways to give an effective lecture.", "December 14", "3:00 p.m.", address1, "Dr. Lectureson", 300);
        Console.WriteLine($"{lectures.Standard()}");
        Console.WriteLine("");
        Console.WriteLine($"{lectures.FullDetails()}");
        Console.WriteLine("");
        Console.WriteLine($"{lectures.Short()}");
        Console.WriteLine("\n");Console.WriteLine("");

        // Event 2 - Reception
        Address address2 = new Address("8 Example Lane", "Old Sample City", "Not Wyoming", "Not USA");
        Receptions receptions = new Receptions("Practice Reception", "A mock reception designed to teach appropriate etiquette for the real deal.", "May 1", "10:00 a.m.", address2, "practice.reception@email.net");
        Console.WriteLine($"{receptions.Standard()}");
        Console.WriteLine("");
        Console.WriteLine($"{receptions.FullDetails()}");
        Console.WriteLine("");
        Console.WriteLine($"{receptions.Short()}");
        Console.WriteLine("\n");Console.WriteLine("");

        // Event 3 - Outdoor Gathering
        Address address3 = new Address("Strong Badia", "Freedomtown", "Free Country", "USA");
        Outdoor outdoor = new Outdoor("Big-time Cookout", "Come celebrate Independence Day with some great food and games!", "July 4", "9:00 a.m.", address3, "sunny");
        Console.WriteLine($"{outdoor.Standard()}");
        Console.WriteLine("");
        Console.WriteLine($"{outdoor.FullDetails()}");
        Console.WriteLine("");
        Console.WriteLine($"{outdoor.Short()}");
        Console.WriteLine("\n");Console.WriteLine("");
    }
}