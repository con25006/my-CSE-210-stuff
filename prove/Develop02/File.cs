class File
{
    public void Save(Journal entriesToSave)
    {
        Console.WriteLine("Provide a name for your journal:");
        string journalName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(journalName))
        {
            foreach (Entry entry in entriesToSave._entries)
            {
                outputFile.WriteLine($"{entry._date} ~ {entry._prompt} ~ {entry._response}");
            }
        }
    }
    public Journal Load()
    {
        Journal journal = new Journal();
        Console.WriteLine("What is the name of your previously saved journal?");
        string loadJournal = Console.ReadLine();
        try
        {
            string[] lines = System.IO.File.ReadAllLines(loadJournal);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~");

                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                Entry entry = new Entry();
                entry._date = date;
                entry._prompt = prompt;
                entry._response = response;

                journal._entries.Add(entry);
            }
        } catch (System.IO.FileNotFoundException)
        {
            Console.Write("Invalid journal name. Try again.");
        }
        return journal;
    }
}