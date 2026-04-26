using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userAnswer = Console.ReadLine();
        int gradePercent = int.Parse(userAnswer);

        string letterGrade = "";

        if (gradePercent >= 93)
        {
            letterGrade = "A";
        }
        else if (gradePercent >= 90)
        {
            letterGrade = "A-";
        }
        else if (gradePercent >= 87)
        {
            letterGrade = "B+";
        }
        else if (gradePercent >= 83)
        {
            letterGrade = "B";
        }
        else if (gradePercent >= 80)
        {
            letterGrade = "B-";
        }
        else if (gradePercent >= 77)
        {
            letterGrade = "C+";
        }
        else if (gradePercent >= 73)
        {
            letterGrade = "C";
        }
        else if (gradePercent >= 70)
        {
            letterGrade = "C-";
        }
        else if (gradePercent >= 67)
        {
            letterGrade = "D+";
        }
        else if (gradePercent >= 63)
        {
            letterGrade = "D";
        }
        else if (gradePercent >= 60)
        {
            letterGrade = "D-";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("A WINNER IS YOU");
        }
        else
        {
            Console.WriteLine("Come back when you can put up a fight.");
        }
    }
}