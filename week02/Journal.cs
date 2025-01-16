using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
{
        Console.WriteLine("Welcome");
        Journal journal = new Journal();
        journal.Run();
    }
}

public class Entry
{
    string _entries = new Entry(string_entries);

    public void ()
{
        while (true)
        {
            Console.WriteLine("Please chose from the following options: ");
            string options =  Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\n");
            int menu = int.Parse(Console.ReadLine());
            
            switch (menu)
            {
            case "write": 
            Console.WriteUserInput();
            break;
            
            case "Display":
            Console.DisplayUserInput();
            break;
            
            case "Load":
            Console.LoadUserInput();
            break;

            case "Save":
            Console.SaveUserInput();
            int SaveUserInput = int.Parse(Console.ReadLine(Entry.cs));
            case "quit":
            Console.Exit();
            }
        }
    }

}
public class PromptGenerator
{
    public string GetRandomPrompt()
    {
        
    }
}