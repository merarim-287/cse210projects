using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
    }
}

public class ScriptureMemorizer
{
    public string GetScripture { get; set; }
    {
        public Words(string text)
    {
        Text = text;
        Words = List<Word>();
    }
}

public class Word
{
    public Reference Reference { get; }
    public List<Word> Words { get; }

    public Scripture(Reference reference, List<Word> words)
    {
        Reference = reference;
        Words = SplitWords(words);
    }

    private List<Word> SplitWords(string text)
    }

return words;
    }
}
