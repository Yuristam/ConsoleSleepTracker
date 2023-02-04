using ConsoleSleepTracker.Menu;
using Microsoft.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        /*SqlConnection connection = new SqlConnection(ConnectionString);*/

        Menu.MainMenu();
    }
}