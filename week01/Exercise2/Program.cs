using System;
using System.Formats.Asn1;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade score? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(answer);

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
    }
}