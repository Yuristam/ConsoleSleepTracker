namespace ConsoleSleepTracker.Menu;
internal class Menu
{
    internal static void MainMenu()
    {
        //============================================
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to the program, My Dear Lord!");
        for(int i =0; i < Console.BufferWidth; i++)
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

        string userInput = Console.ReadLine();
        Console.Clear();
    }
}