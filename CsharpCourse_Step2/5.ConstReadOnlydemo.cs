using System;

class ConstReadOnlydemo
{
    const double pi = 3.142;
    readonly string createdDate = "12-Dec-2024";
    public ConstReadOnlydemo(string date)
    {
        createdDate = date;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"pi value is : {ConstReadOnlydemo.pi}");

        ConstReadOnlydemo file1 = new ConstReadOnlydemo("12-Dec-1364");
        Console.WriteLine(file1.createdDate);
    }
}
