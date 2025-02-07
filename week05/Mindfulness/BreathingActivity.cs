class BreathingActivity : Activity
{
    public BreathingActivity
    {
        Console.WriteLine("Welcome. The Breathing Activity will guide you to make breathing exercises that willl help you relax.");
        Console.WriteLine("Please select the duration of your breathing exercise in seconds.");
        Console.WriteLine("5seconds");
        Console.WriteLine("10seconds");
        Console.WriteLine("15seconds");

        string userInput = Console.ReadLine();
        int seconds = int.Parse(UserInput);

while (seconds != 5 seconds)
        if (seconds == 5)
        { 
            Console.WriteLine("Breathe in...");

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.sleep(5000);
            }

            Console.WriteLine("Breathe out...");

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.sleep(5000);
            }

            Console.WriteLine("Well done.");

            }
            else if (seconds == 10)
            {
                Console.WriteLine("Breathe in...");

                for (int i = 10; i > 0; i--)    
                {
                    Console.WriteLine(i);
                    Thread.sleep(10000);
                }

                Console.WriteLine("Breathe out...");

                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.sleep(10000);
                }

                Console.WriteLine("Well done.");\
            }
    }