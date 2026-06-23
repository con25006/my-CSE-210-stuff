using System.Collections.Concurrent;

class Reference
{
    // attributes
    private string _book;
    private int _chapter;
    private int _startverse;
    private int _endverse;

    //behaviors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = verse;
        _endverse = verse;
    }
    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;
    }
    public string GetReference()
    {
        string reference;

        if (_startverse != _endverse)
        {
            reference = $"{_book} {_chapter}:{_startverse}-{_endverse}";
        }
        else
        {
            reference = $"{_book} {_chapter}:{_startverse}";
        }
            
        return reference;
    }
}