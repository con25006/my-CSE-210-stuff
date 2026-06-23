class Word
{
    // attributes
    private string _word;
    private bool _revealed;

    //behaviors
    public Word(string word)
    {
        _word = word;
        _revealed = true;
    }
    public string GetWord()
    {
        if (_revealed == true)
        {
            return _word;
        }
        else
        {
            string underscores = new string('_',_word.Length); // takes the underscore and multiplies it by the integer from word.Length
            return $"{underscores}";
        }
    }
    public void Hide()
    {
        _revealed = false;
    }
    public int IsHidden()
    {
        int isHidden = 0;
        if (_revealed == false)
        {
            isHidden = 1;
        }
        return isHidden;
    }
}