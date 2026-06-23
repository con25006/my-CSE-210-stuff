class Journal
{
    // attributes
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = [
        "How would you feel if you didn't eat breakfast this morning?",
        "Would you rather fight a T-Rex-sized chicken or 100 chicken-sized T-Rexes?",
        "Where were you at 11:37 am on Tuesday the 2nd?",
        "What is the strongest emotion you felt today?",
        "Do you know the muffin man?",
    ];
    
    // behaviors
    public string PullPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(5);
        string randomPrompt = _prompts[randomNumber];
        return randomPrompt;
    }
    public void AddEntry(string prompt)
    {
        Console.WriteLine($"Your prompt is: {prompt}");
        Console.WriteLine("Write your journal entry here: ");
        string newJournalEntry = Console.ReadLine();
        Entry entry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        // I would use 'string entry._date' if I hadn't already defined '_date' as a string in the Entry class
        entry._date = theCurrentTime.ToShortDateString();
        entry._prompt = prompt;
        entry._response = newJournalEntry;
        _entries.Add(entry);
        // entry.Display(); // delete this later
    }
    public void DisplayEntries()
    {
        foreach (Entry printedEntry in _entries)
        {
            printedEntry.Display();
        }
        // return "";
    }
}