class ReflectionActivity : Activity
{
    public ReflectionActivity()
    {
        Console.Write(message1 + message4);
        
        bool continueActivity = true;
        while (continurActivity)
        {

        string prompt = GetRandomPrompt(string prompt); 
        
        Console.WriteLine(prompt); //  prompt
       
        string animationString = response.Substring(); // animation
        Display(animationString);
        }

    public string responseText()
    {
        string response = Console.ReadLine(); // user response

        string subPrompt = GetRandomSubPrompt(prompt, response); // sub prompt

        string animationString = response.Substring(); // animation
        Display(animationString);

        string subPrimpt response = Console.ReadLine(); // user response

        
        return (message3);
        }
    }
}


