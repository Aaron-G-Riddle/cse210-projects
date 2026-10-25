class Scripture
{
    private List<Word> _words;
    private ScriptureReference _reference;
    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);
        _reference = new ScriptureReference(bookName, chapter, verse);
    }

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _words = ConvertToWordList(text);
        _reference = new ScriptureReference(bookName, chapter, startVerse, endVerse);
    }

    public void ShowScripture()
    {
        _reference.DisplayScriptureReference();

        foreach(Word word in _words)
        {
            word.DisplayWord();
        }
    }

    public void HideRandomWords()
    {
        Random rand = new Random();

        for (int i = 0; i < 3; i++)
        {
            int randomIndex = rand.Next(0, _words.Count);
            _words[randomIndex].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach (string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }
        return tempWordList;
    }
}