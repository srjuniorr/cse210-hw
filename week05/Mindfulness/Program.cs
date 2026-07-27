using System;

class Program
{
    // Exceeding requirements:
    // 1. The reflecting activity never repeats a question until all of them
    //    have been used, so the session feels less repetitive.
    // 2. The program keeps a count of how many times each activity was done
    //    and shows a summary of the session when you quit.
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                running = false;

                Console.WriteLine();
                Console.WriteLine("Session summary:");
                Console.WriteLine($"Breathing activity: {breathingCount} time(s)");
                Console.WriteLine($"Reflecting activity: {reflectingCount} time(s)");
                Console.WriteLine($"Listing activity: {listingCount} time(s)");
            }
        }
    }
}
