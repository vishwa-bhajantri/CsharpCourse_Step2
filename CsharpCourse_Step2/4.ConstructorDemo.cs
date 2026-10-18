using System;

class ConstructorDemo
{

    string filename = "kd";
    string filelocation = "Dharwad";
    string filesize = "10TB";
    string createdate = "10-20-2025";

    public ConstructorDemo()
    {
        Console.WriteLine("File Object Created");
        Console.WriteLine(filename);

    }

    public ConstructorDemo(string filename, string filelocation, string filesize)
    {
        Console.WriteLine(filename);
        Console.WriteLine(filelocation);
        Console.WriteLine(filesize);

    }
    static void Main()
    {
        ConstructorDemo constructorDemo = new ConstructorDemo();
        ConstructorDemo file1 = new ConstructorDemo("kjbkhv", "jhvj", "treytf");
    }
}

