// created using cd sandbox
// then, in PS C:\Users\heyij\Documents\Spring 2026\CSE 210 - Programming with Classes\my-CSE-210-stuff\sandbox>
// type the following:
// dotnet new console -o Animal
public class Program
{
    public static void Main()
    {
        List<Animal> myAnimals = new List<Animal>();
        myAnimals.Add = new Animal("Liger");
        myAnimals.Add = new Dog("Zorro");
        myAnimals.Add = new Cat("Garfield");
        // myAnimals[0].MakeNoise();
        // myAnimals[1].MakeNoise();
        foreach (Animal critter in myAnimals)
        {
            critter.MakeNoise();
        }
    }
}