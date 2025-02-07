class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project. Please make your selection. 1: Breathing Activity, 2: Listing Activity, 3: Reflection Activity.");
        string userInput = Console.ReadLine();
        int menu = int.Parse(userInput);

        
        if (menu == "1")
        {
            Console.WriteLine("Mindfulness Activity");
        }
        else if (menu == "2")
        {
            Console.WriteLine("Listing Activity");
        }
        else if (menu == "3")
        {
            Console.WriteLine("Reflection Activity");
        }
        else
        {
            return 
        }
       
    }
}