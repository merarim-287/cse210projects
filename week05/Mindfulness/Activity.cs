

List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("|");

        foreach (string s in animationStrings)
        {
            Console.WriteLine(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }

class Prompts : Reflection
{
    public List<string> Prompts = new List<string>
    {
        Prompt1 = "Think of a time when you did something really difficult."
        Prompt2 = "Think of a time when you stood up for someone else."
        Prompt3 = "Think of a time when you helped someone in need  ."
    }
}
 class SubPrompts : Reflection
    {
        public List<string> SubPrompts = new List<string>
        {
            SubPrompt1 = "Why was this experience meaningful to you?"
            SubPrompt2 = "Have you ever done anything like this before?"
            SubPrompt3 = "How did you get started?"
        }
    }