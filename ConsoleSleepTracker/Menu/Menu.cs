using ConsoleSleepTracker.Context;
using ConsoleSleepTracker.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleSleepTracker.Menu;
internal class Menu
{
    private static readonly DbContextOptions<SleepDbContext> connectionString;

    internal static void MainMenu()
    {
        while (true)
        {
            //============================================
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the program, My Dear Lord!");
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Console.Write('=');
            }
            Console.ResetColor();
            //============================================

            //Menu Commands
            //============================================
            Console.WriteLine("1. Enter the time when I get to sleep.\r\n" +
                "2. Show the schedule.\r\n" +
                "3. Exit.");
            //============================================

            Console.SetCursorPosition(5, 15);
            Console.WriteLine("Type numbers to choose any option.\r\n" +
                "Example: 1 to choose 1 option and enter time you go bed and wake up.\r\n" +
                "");

            //============================================
            Console.SetCursorPosition(0,5);
            Console.Write('>');
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    OptionOne();
                    break;
                case "2":
                    OptionTwo();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Type something better, My Lord!");
                    break;
            }
            Console.Clear();
        }
    }
    static void OptionOne()
    {
        var connectionString = "server=(localdb)\\MSSQLLocalDB;database=SleepDb;trusted_connection=true";
        var context = new SleepDbContext(connectionString);

        /*string userInput;*/

        // Entering Day, like: 12.02.2023
        //=========================================================================
        Console.WriteLine("Enter the today's date, My Dear Lord:");
        Console.Write(">");
        // DateOnly 
       
        Day day = new();

        DateTime inputDay;
        while (!DateTime.TryParse(Console.ReadLine(), out inputDay))
        {
            Console.Clear();
            Console.WriteLine("You entered an invalid date, My Dear Lord!\r\n" +
                "Please enter Date:");
            Console.Write(">");
        }
        //=========================================================================

        //Entering Go To Bed Time, like: 23:00
        //=========================================================================
        Console.Clear();
        Console.WriteLine("Enter time when you go to bed, My Lord:");
        Console.Write(">");

        DateTime inputBedTime;
        while (!DateTime.TryParse(Console.ReadLine(), out inputBedTime))
        {
            Console.Clear();
            Console.WriteLine("You entered an invalid Time, Little Star!\r\n" +
                "Please enter BedTime, Little Star:");
            Console.Write(">");
        }
        //=========================================================================

        //Entering Wake Up Time, like: 7:00
        //=========================================================================
        Console.Clear();
        Console.WriteLine("Enter time when You wake up, Sleeping Beauty:");
        Console.Write(">");

        DateTime inputWakeUpTime;
        while (!DateTime.TryParse(Console.ReadLine(), out inputWakeUpTime))
        {
            Console.Clear();
            Console.WriteLine("You entered an invalid Time, Sleeping Beauty!\r\n" +
                "Please enter WakeUpTime, Sleeping Beauty:");
            Console.Write(">");
        }
        //=========================================================================

        day = new() { Date = inputDay, GoToSleepTime = inputBedTime, GetUpTime = inputWakeUpTime };

        context.Days.Add(day);
        context.SaveChanges();
        Console.WriteLine("You successfully added new day, My Master!");
        Console.ReadKey();
        //=========================================================================
    }

    static void OptionTwo()
    {
        var connectionString = "server=(localdb)\\MSSQLLocalDB;database=SleepDb;trusted_connection=true";
        var context = new SleepDbContext(connectionString);

        var days = context.Days;
        
        Console.WriteLine("Showing All Days, My Lord!\r\n");   
        foreach (Day day in days)
        {
            Console.WriteLine($" Id: {day.Id} | Day: {day.Date.ToString("dd.MMMM.yyyy")} {day.Date.DayOfWeek} | Go To Bed: {day.GoToSleepTime.TimeOfDay} | Wake Up: {day.GetUpTime.TimeOfDay}");
        }
        Console.WriteLine("\r\nPress any button to get back.");
        Console.ReadKey();
    }
}