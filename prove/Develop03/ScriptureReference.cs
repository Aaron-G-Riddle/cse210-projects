class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    private int[] _verse;

    public ScriptureReference(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = new int[1];
        _verse[0] = verse;
    }

    public ScriptureReference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = new int[2];
        _verse[0] = startVerse;
        _verse[1] = endVerse;
    }

    public void DisplayScriptureReference()
    {
        Console.WriteLine(GetScriptureReferenceString());
    }

    public string GetScriptureReference()
    {
        return GetScriptureReferenceString();
    }

    private string GetScriptureReferenceString()
    
    {
        string reference;
        if (_verse.Length == 1)
        {
            reference = $"{_bookName} {_chapter}:{_verse[0]}";
        }
        else
        {
            reference = $"{_bookName} {_chapter}:{_verse[0]}-{_verse[1]}";
        }
        return reference;
    }
}