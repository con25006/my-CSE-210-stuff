using System.Diagnostics;

class Scripture
{
    // attributes
    private List<Word> _scripture;
    private Reference _reference;
    // behaviors
    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;
        string[] wordlist = scripture.Split(" ");
        _scripture = new List<Word>();
        foreach(string word in wordlist)
        {
            _scripture.Add(new Word(word));
        }
    }
    public void RandomWord()
    {
        Random random = new Random();
        int random_scrip = random.Next(_scripture.Count);
        _scripture[random_scrip].Hide(); // make this actually random
    }
    public int CountRevealed()
    {
        int totalRevealed = (_scripture.Count);
        foreach(Word word in _scripture)
        {   
            int hidden = word.IsHidden();
            if (hidden == 1)
            {
                totalRevealed -= 1;
            }
        }
        return totalRevealed;
    }
    public void Display()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine(_reference.GetReference());
        foreach(Word word in _scripture)
        {
            Console.Write($"{word.GetWord()} ");
        }
    }
}