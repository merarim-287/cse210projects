class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project. Please make your selection. 1: Breathing Activity, 2: Listing Activity, 3: Reflection Activity.");
        string userInput = Console.ReadLine();
        int menu = int.Parse(userInput);

        
        if (menu == "1")
        {
            Console.WriteLine("Breathing Activity");
            Breathing breathing = new Breathing();
            bool is running = true;

            while (is running)
            {
                breathing.Run();
                Console.WriteLine("Back to menu");
                Console.WriteLine("Start breathing activity.");
                Console.WriteLine("Exit.");

                int choice = Convert.toint32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        breathing.Run();
                        break;
                    case 2:
                        is running = false;
                        break;
                }
            }

        }
        else if (menu == "2")
        {
            Console.WriteLine("Listing Activity");
            Breathing listing = new Listing();
            bool is running = true;
        }
            while (is running)
            {
                listing.Run();
                Console.WriteLine("Back to menu");
                Console.WriteLine("Start Listing Activity.");
                Console.WriteLine("Exit.");

                int choice = Convert.toint32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        listing.Run();
                        break;
                    case 2:
                        is running = false;
                        break;
                }
        }
        else if (menu == "3")
        {
            Console.WriteLine("Reflection Activity");
             Reflection reflection = new Reflection();
            bool is running = true;

            while (is running)
            {
                reflection.Run();
                Console.WriteLine("Back to menu");
                Console.WriteLine("Start Reflection Activity.");
                Console.WriteLine("Exit.");

                int choice = Convert.toint32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Reflection.Run();
                        break;
                    case 2:
                        is running = false;
                        break;
                }
        break;
        {
        
        }
       
    }
}