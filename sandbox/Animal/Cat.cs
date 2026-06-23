class Cat : Animal
{
    public Cat(string name) : base(name)
    {
        // nothing here on purpose, just need the base constructor for the program to compile
    }
    // overridden behavior
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says 'I hate Mondays...'");
    }
}