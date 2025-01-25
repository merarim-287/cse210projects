using system.IO;


public class Scripture
{
    public class ScriptureStorage
    {
        private Dictionary<string, string> scripturestorage = new Dictionary<string, string>();

        public ScriptureStorage()
        {
            SciptureStorage.Add("Moses 1:1", "1 The words of God, which he spake unto Moses at a time when Moses was caught up into an exceedingly high mountain");
            ScriptureStorage.Add("Moses 1:2", "2 And he saw God face to face, and he talked with him, and the glory of God was upon Moses; therefore Moses could endure his presence.");
            ScriptureStorage.Add("Moses 1:3", "3 And God spake unto Moses, saying: Behold, I am the Lord God Almighty, and Endless is my name; for I am without beginning of days or end of years; and is not this endless?");
        }

        public string GetSCripture(string reference)
        {
            return scripturestorage[reference];
        }
    }
    public Reference ScriptureStorage { get; set; }
    public string Verse { get; set; }

    public Scripture(Reference reference, string text)
    {
        ScriptureReference = reference;
        Verse = text;
    }

    public string ToString()
    {
        return $"{ScriptureStorage.GetSCripture(ScriptureReference.Reference).ToString()} - {Text}";

    }
    