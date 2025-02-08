public class Activity
{


public class Prompts : Reflection
{
    public List<string> Prompts = new List<string>
    {
        Prompt1 = "Think of a time when you did something really difficult."
        Prompt2 = "Think of a time when you stood up for someone else."
        Prompt3 = "Think of a time when you helped someone in need  ."
    }
    public class SubPrompts : Reflection
    {
        public List<string> SubPrompts = new List<string>
        {
            SubPrompt1 = "Why was this experience meaningful to you?"
            SubPrompt2 = "Have you ever done anything like this before?"
            SubPrompt3 = "How did you get started?"
        }
    }
}
   
public class ListingPrompts: ListingActivity
{
    public List<string> ListingPrompts = new List<string>
    {
        ListingPrompt1 = "Who are people that you appreciate?"
        ListingPrompt2 = "What are personal strengths of yours?"
        ListingPrompt3 = "Who are people that you have helped this week?"
        ListingPrompt4 = "When have you felt the Holy Ghost this month?"
        ListingPrompt5 = "Who are some of your personal heroes?"
    }
}