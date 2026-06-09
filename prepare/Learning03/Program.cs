using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        // Fraction fraction1 = new Fraction();
        // Fraction fraction2 = new Fraction(5);
        // Fraction fraction3 = new Fraction(3,4);
        // Fraction fraction4 = new Fraction(1,3);
        // fraction3.GetTop();
        // fraction3.SetTop(1);
        // fraction3.GetBottom();
        // fraction3.SetBottom(1);
        // fraction3.GetFractionString();
        // fraction3.GetDecimalValue();
        // Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} \n {fraction1.GetDecimalValue()}");
        // Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} \n {fraction2.GetDecimalValue()}");
        // Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} \n {fraction3.GetDecimalValue()}");
        // Console.WriteLine($"Fraction 4: {fraction4.GetFractionString()} \n {fraction4.GetDecimalValue()}");
        Fraction fraction = new Fraction();
        Random random = new Random();
        for (int i=0; i<20;i++)
        {
            int top = random.Next(1,99);
            int bottom = random.Next(1,99);
            fraction.SetTop(top);
            fraction.SetBottom(bottom);
            Console.WriteLine($"Fraction {i+1}: {fraction.GetFractionString()} \n{fraction.GetDecimalValue()}");
        }
    }
}