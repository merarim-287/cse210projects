class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Console.Write(message2);
        Console.Write(message2)
        Console.Write(message5)

        string userInput = Console.ReadLine();
        int seconds = int.Parse(userInput);

        
        if (seconds == 5)
        {
          Console.WriteLine("Breathe in...");

            for (int i = 5; i > 0; i--)
            
                Console.WriteLine(i);
                Thread.sleep(5000);
            }

            Console.WriteLine("Breathe out...");

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(5000);
            }

            Console.WriteLine("Well done.");

        }
        else if (seconds == 10)
        {
            Console.WriteLine("Breathe in...");

            for (int i = 10; i > 0; i--)    
            {
                Console.WriteLine(i);
                Thread.Sleep(10000);
            }

            Console.WriteLine("Breathe out...");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(10000);
            }

            Console.WriteLine("Well done.");

        }
        else if (seconds == 15)
        {
            Console.WriteLine("Breathe in...");

            for (int i = 15; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(15000);
            }

            Console.WriteLine("Breathe out...");

            for (int i = 15; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(15000);
            }

            Console.WriteLine("Well done.");

        }
        
        Console.WriteLine(message3);
        return;
    }
