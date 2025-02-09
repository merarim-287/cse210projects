public class Activity

public class duration()
    {
    Console.WriteLine("Please select your desired duration in seconds of this excercise.")
    Console.WriteLine("5 seconds");
    Console.WriteLine("10 seconds");    
    Console.WriteLine("15 seconds");
}

public class Messages()
{
    public List<string> Messages = new List<string>
    {
        Messages messages = message1("Welcome to the Mindfulness Program.");
        Messages messages = message2("Welcome to the Breathing Activity. Here we will guide you to make breathing exercises that willl help you relax.");
        Messages messages = message3("Well done, you can now proceed to the other activities.")
        Messages messages = message4("Welcome. This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        Messages messages = message5(duration);
    }
}

public class ReflectionActivity : Activity
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

public class Animation()
{
    public void Display(string animationString)
    {
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
    }
}
