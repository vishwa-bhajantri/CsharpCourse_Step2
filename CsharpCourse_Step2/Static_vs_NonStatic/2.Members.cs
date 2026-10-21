using System;

namespace StaticAndNonStaticMembers
{
    public static class EmployeeStaticLogger
    {
        public static int EmployeeList = 0;

        public static void LogMessage(string message)
        {
            Console.WriteLine($"Log {message}");
            EmployeeList++;
        }

        public static int GetMessageCount()
        {
            return EmployeeList;
        }
    }

    public class EmployeeNonStaticLogger
    {
        public int EmployeeList = 0;

        public void LogMessage(string message)
        {
            Console.WriteLine($"Log {message}");
            EmployeeList++;
        }

        public int GetMessageCount()
        {
            return EmployeeList;
        }
    }

    class program
    {
        public static void Main()
        {
            //EmployeeStaticLogger.LogMessage("John has Joined on 1-1-2023");
            //EmployeeStaticLogger.LogMessage("Jsson has Joined on 1-1-2023");
            //Console.WriteLine(EmployeeStaticLogger.GetMessageCount());

            EmployeeNonStaticLogger nonStaticLogger = new EmployeeNonStaticLogger();
            nonStaticLogger.LogMessage("John has Joined on 1-1-2023");
            nonStaticLogger.LogMessage("Jsson has Joined on 1-1-2023");
            Console.WriteLine(nonStaticLogger.GetMessageCount());
        }
    }
}