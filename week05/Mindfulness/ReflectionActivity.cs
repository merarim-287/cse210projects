class ReflectionActivity : Activity
{
    public ReflectionActivity()
    {
        Console.WriteLine("Welcome. This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        
        bool continueActivity = true;
        while (continurActivity)
        {

        string prompt = GetRandomPrompt(string prompt); 
        
        Console.WriteLine(prompt); //  prompt
        
        string animationString = response.Substring(); // animation
        Display(animationString);

        string response = Console.ReadLine(); // user response

        string subPrompt = GetRandomSubPrompt(prompt, response); // sub prompt

        string animationString = response.Substring(); // animation
        Display(animationString);

        string subPrimpt response = Console.ReadLine(); // user response

        
        return;
        }
    }
}


