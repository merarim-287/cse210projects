using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)

        Console.WriteLine("Please chose from the following options: ");
            string options = Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\n");
    int menu = int.Parse(Console.ReadLine());
            
            switch (menu)
            {
            case "write": 
            Console.Entry();
            break;
            
            case "Display":
            Console.Display();
            break;
            
            case "Load":
            Console.LoadUserEntry();
            break;

            case "Save":
            Console.SaveEntry();
            int SaveEntry = int.Parse(Console.ReadLine(Entry.cs));
            case "quit":
            Console.Exit();
            }
        }
    


public class PromptGenerator
{
    public string GetRandomPrompt()
    {

    }
}

public class Entry
{
    Console.WriteLine()
}
