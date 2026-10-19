using System;

static class Logger
{
    //Fields
    static string logfile = "apllication.txt";
    static string logFileDiscription = "you have logged in the App at Mar-05-2021 at 1 pm";

    //Properties
    static string Logfile { get; set;  }

    //Constructor
    static Logger()
    {
        Logger.Logfile = logfile;
    }

    //Method
    static void LogMessage(string level, string message)
    {
        Console.WriteLine($"{DateTime.Now} {level} {message}");
    }

    static void LogInfo(string message)
    {
        LogMessage("INFO", message);
    }

    static void LogWarning(string message)
    {
        LogMessage("Warning", message);
    }

    static void LogError(string message)
    {
        LogMessage("Error", message);
    }
    static void Main()
    {
        Console.WriteLine($"LoggerFile name is {Logger.logfile}");
        Console.WriteLine($"Log File Discription is : {Logger.logFileDiscription}");
        Console.WriteLine($"Log File Property is : {Logger.Logfile}");

        Logger.LogMessage("Basic", Logger.logFileDiscription);
        Logger.LogInfo("Application has started");
        Logger.LogWarning("You have enterd wrong password");
        Logger.LogError("Something is wrong");
    }
}
