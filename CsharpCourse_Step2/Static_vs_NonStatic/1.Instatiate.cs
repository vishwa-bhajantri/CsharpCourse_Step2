using System;

namespace StaticAndNonStaticInstantiate
{
    public static class StaticClass
    {
        public static void PrintMessage()
        {
            Console.WriteLine("This is a Static Class Method");
        }
    }

    public class NonStatic
    {
        public void PrintMessage()
        {
            Console.WriteLine("This is a Non Static Class Method");
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            StaticClass.PrintMessage();

            NonStatic k = new NonStatic();
            k.PrintMessage();
        }
    }
}