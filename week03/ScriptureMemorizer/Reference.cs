public class Reference
{
    public string ScriptureStorage.Text { get; set; }

    public Reference(string verse, string ScriptureText) : this(default)
    {
        string Reference = "Pearl of Great Price, Moses 1:1-3";
        ScriptureStorage.Text = ScriptureText;
    }
}

