using ClassLib;

public class Program
{
    public static void Main(string[] args)
    {
        Log log = new Log("file1.txt");
        log.Write("This is a normal log message.");
        Console.WriteLine("Writing the normal log:");
        log.DisplayLog();
        Console.WriteLine();

        ActivityLog activityLog = new ActivityLog("file2.txt");
        activityLog.Write("Person X entered the building.");
        activityLog.Write("Person Y entered the building.");
        activityLog.Write("Person X left the building.");
        activityLog.Write("Person Z entered the building.");
        Console.WriteLine("Writing the activity log:");
        activityLog.DisplayLog();
        Console.WriteLine();

        ErrorLog errorLog = new ErrorLog("file3.txt");
        errorLog.Write("This is an error log message.");
        Console.WriteLine("Writing the error log:");
        errorLog.DisplayLog();
        Console.WriteLine();


        Console.ReadLine();
    }
}