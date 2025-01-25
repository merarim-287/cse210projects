using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace ScriptureMemorizer
{
    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
    }
}

Console.Clear();

public class Scripture
{
    public string verse { get; set; }
    public Scripture(Reference reference, string verse)
    {
        string Text = scriptureStorage.Text;
        Console.WriteLine(verse);
    }  
        while (true)
        {
            Console.WriteLine("Please press Enter to hide words, or typw 'quit' to exit.");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;      
            }

            scripture.HideRandomWord();

            Console.WriteLine(scripture.ToString());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            elif(input == "enter")
    {
        Console.WriteLine(scripture.Hider());
    }
}           
    }