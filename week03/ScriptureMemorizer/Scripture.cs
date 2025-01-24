using system.IO;


public class Scripture

{
    public Reference ScriptureStorage { get; set; }
    public string Text { get; set; }

    public Scripture(Reference reference, string text)
    {
        ScriptureReference = reference;
        Text = text;
    }

    public string TOString()
    {
        return $"{ScriptureStorage.GetSCripture(ScriptureReference.Reference).ToString()} - {Text}";

    }
    ublic class Scripture
    {
        public string Text { get; set; }

        public Scripture(Reference reference, string verse)
        {
            Console.WriteLine(verse);

            string Text = scriptureStorage.Text;
            Console.WriteLine(text);
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

        public void Hider
        {

        }

return words;
    }
}
