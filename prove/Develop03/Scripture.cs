class Scripture
{
    private List<Word> _words;
    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);

        _words[7].Hide();
    }

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        // todo
    }

    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.DisplayWord();
        }
    }
    
// TODO - Add constructor for ScriptureReference

/*
* ConvertToWordList() - this method will receive a string parameter,
* which is a paragraph of text. It will split that text into words
* and add those words to a List<word> and return the list
*/
private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach (string w in tempWords)
        {
            // Console.WriteLine(w);
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }
        return tempWordList;
    }
}