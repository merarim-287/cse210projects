using System;
using System.Collections.Generic;

public class Word
{
    public string Text { get; set; }
    public Hider { get; set; }

public Word(verse)
{
    Verse = text;
    Hider = false;
}

public Hider()
{
    Hider = true;
}

public override string ToString()
{
    return Hider ? new string('_', RandomWord.Length) : Text;
}
}


public void HideWord()
{
    RandomWord randomword = new RandomWord();
    int index = randomword.Next(Word.Count);

    Word[index].Hider();
}

public override string ToString()
{
    string verse = string.Empty;
    forword(word in words)
    {
        text += word.ToString() + " ";
    }

    return $"{Reference}: {text.Trim()}";
}
}

